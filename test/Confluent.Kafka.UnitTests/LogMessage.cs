// Copyright 2016-2017 Confluent Inc.
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
//
// Refer to LICENSE for more information.

using Xunit;


namespace Confluent.Kafka.UnitTests
{
    public class LogMessageTests
    {
        [Fact]
        public void Constuctor()
        {
            var lm = new LogMessage("myname", 42, "myfacility", "mymessage");
            Assert.Equal(lm.Name, "myname");
            Assert.Equal(lm.Level, 42);
            Assert.Equal(lm.Facility, "myfacility");
            Assert.Equal(lm.Message, "mymessage");
        }
    }
}
