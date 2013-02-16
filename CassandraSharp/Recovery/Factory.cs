﻿// cassandra-sharp - a .NET client for Apache Cassandra
// Copyright (c) 2011-2013 Pierre Chalamet
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace CassandraSharp.Recovery
{
    using System;
    using System.Collections.Generic;
    using CassandraSharp.Utils;

    internal class Factory : IServiceDescriptor
    {
        private static readonly IDictionary<string, Type> _def = new Dictionary<string, Type>
            {
                    {"Default", typeof(AttemptConnectRecoveryService)},
                    {"Null", typeof(NullRecoveryService)},
                    {"AttemptConnect", typeof(AttemptConnectRecoveryService)},
            };

        public IDictionary<string, Type> Definition
        {
            get { return _def; }
        }
    }
}