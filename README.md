## Synopsis

The NIC Federal .Net RIDB Client project provides an easy way for RIDB data to be used in .NET applications and websites.
The client library wraps up the full capabilities of the RIDB JSON API into a simple to use client gateway that returns .Net
objects.

## Code Example

To use the RIDB client library, you must first instantiate the a `RIDBClient` object.  You have two choices regarding how to do this.  The first is
to use the default constructor in which case the RIDB settings will be pulled from your application `AppSettings` configuration.

### Default Constructor

	// <configuration>
	// 	<appSettings>
	// 		<add key="RIDB.BaseUrl" value="https://ridb.recreation.gov/api/v1"/>
	// 		<add key="RIDB.ApiKey" value="555AAQWSDDA348BF42E20F8988280535"/>
	// 	</appSettings>
	// </configuration>

	RIDBClient ridb = new RIDBClient();

### Paramerized Constructor

	RIDBClient ridb = new RIDBClient("https://ridb.recreation.gov/api/v1", "555AAQWSDDA348BF42E20F8988280535");

### Client Modules

Once the `RIDBClient` object is constructed, RIDB data is accessed by calling modules on that client object.  There are a total of
10 modules.  Each module corresponds to an entity within RIDB.

*	Activity
*	Campsite
*	Event
*	Facility
*	Link
*	Media
*	Org
*	PermitEntrance
*	RecArea
*	Tour

To use a module, you reference the property of the client object corresponsing to the entity for which you wish to retrieve data from RIDB.  Here are
examples of several popular modules being used to access RIDB data.  These examples assume that the client object has already been instantiated
for use as discussed above.

	// Retrieve all organizations from RIDB
	RIDBOrganization[] allOrgs = ridb.Org.GetAll();

	// Search for recreation areas with "yellowstone" in their title or metadata
	RIDBList<RIDBRecArea> yellowstoneRecAreas = ridb.RecArea.Search(new RIDBSearchParameters() { Query = "yellowstone" });

	// Get all facilities associated with RecArea 123
	RIDBFacility[] facilities = ridb.RecArea.GetAllFacilities(123);

	// retrieve a specific facility
	RIDBFacility facility = ridb.Facility.Get(456);

## API Reference

TODO

## Build and Installation

TODO

## Tests

A test suite is provided in the solution using the integrated Visual Studio testing framework.  Use Visual Studio's test explorer
to see which tests are available or to run all tests.

## Contributors

This framework was originally created by the NIC team at the myAmerica Developer Summit in Washington, DC.  In the weeks that followed,
what was started at the hackathon was finished by the NIC Federal team.  It is the hope of NIC Federal that others will find this
useful and will contribute fixes, improvements, and features.

## License

The NIC Federal .NET RIDB Client project is licensed under the Apache 2.0 license.  Therefore, the
following license rights apply.

> Copyright 2015 NIC Federal
>
> Licensed under the Apache License, Version 2.0 (the "License");
> you may not use this file except in compliance with the License.
> You may obtain a copy of the License at
> 
>    (http://www.apache.org/licenses/LICENSE-2.0)
> 
> Unless required by applicable law or agreed to in writing, software
> distributed under the License is distributed on an "AS IS" BASIS,
> WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
> See the License for the specific language governing permissions and
> limitations under the License.

The .NET RIDB Client makes use of the JSON.net library for parsing and rendering
JSON from .NET objects.  The JSON.net open source framework is licensed under the MIT
license type.  Accordingly, use and distribution of that library must comply with
the following license terms.

> The MIT License (MIT)
> Copyright (c) 2007 James Newton-King
> 
> Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"),
> to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense,
> and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
> 
> The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
> 
> THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
> FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
> LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
> IN THE SOFTWARE.
