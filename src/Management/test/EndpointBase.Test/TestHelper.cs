﻿// Copyright 2017 the original author or authors.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Steeltoe.Management.Endpoint.CloudFoundry;
using Steeltoe.Management.Endpoint.Hypermedia;
using System.Collections.Generic;

namespace Steeltoe.Management.Endpoint.Test
{
    public static class TestHelper
    {
        public static IEnumerable<IManagementOptions> GetManagementOptions(params IEndpointOptions[] options)
        {
            var mgmtOptions = new CloudFoundryManagementOptions();
            mgmtOptions.EndpointOptions.AddRange(options);
            var actuatorOptions = new ActuatorManagementOptions();
            actuatorOptions.EndpointOptions.AddRange(options);
            return new List<IManagementOptions>() { mgmtOptions, actuatorOptions };
        }
    }
}