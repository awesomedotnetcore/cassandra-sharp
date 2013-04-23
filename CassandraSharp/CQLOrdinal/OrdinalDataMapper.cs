﻿// cassandra-sharp - high performance .NET driver for Apache Cassandra
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

namespace CassandraSharp.CQLOrdinal
{
    using CassandraSharp.Extensibility;

    internal class OrdinalDataMapper : IDataMapper
    {
        public OrdinalDataMapper(object[] dataSource)
        {
            if (null != dataSource)
            {
                DataSource = new OrdinalDataSource(dataSource);
            }
        }

        public IDataSource DataSource { get; private set; }

        public IInstanceBuilder CreateBuilder()
        {
            return new OrdinalInstanceBuilder();
        }
    }
}