﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

/*
Copyright 2015 NIC Federal

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/
namespace NICFederal.RIDB.Client
{
    /// <summary>
    /// Provides information on the permitted equipment at a campsite.
    /// </summary>
    [DataContract(Name="PermittedEquipment")]
    public class RIDBPermittedEquipment
    {
        /// <summary>
        /// The name of the equipment.
        /// </summary>
        [DataMember]
        public string EquipmentName { get; set; }
        
        /// <summary>
        /// The maximum length of the equipment.
        /// </summary>
        [DataMember]
        public int? MaxLength { get; set; }
        
        // RIDB BUG:  The field PermittedEquipmentID is omitted from the data dictionary
        /// <summary>
        /// The id of the permitted equipment.
        /// </summary>
        [DataMember]
        public int? PermittedEquipmentID { get; set; }
    }
}
