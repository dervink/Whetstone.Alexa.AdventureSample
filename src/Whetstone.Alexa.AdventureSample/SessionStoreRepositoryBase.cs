﻿// Copyright (c) 2018 Whetstone Technologies. All rights reserved.
//
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Whetstone.Alexa.AdventureSample.Models;

namespace Whetstone.Alexa.AdventureSample
{
    public abstract class SessionStoreRepositoryBase
    {

        protected string GetUserId(AlexaRequest req)
        {
            string userId = req?.Session?.User?.UserId;
            return userId;
        }


        public abstract Task<string> GetCurrentNodeNameAsync(AlexaRequest req);



        public async Task<AdventureNode> GetCurrentNodeAsync(AlexaRequest req, IEnumerable<AdventureNode> nodes)
        {

            string curNodeName = await GetCurrentNodeNameAsync(req);
            AdventureNode curNode = null;

            if (!string.IsNullOrWhiteSpace(curNodeName))
            {
                curNode = nodes.FirstOrDefault(x => x.Name.Equals(curNodeName));
            }

            return curNode;
        }

    }
}
