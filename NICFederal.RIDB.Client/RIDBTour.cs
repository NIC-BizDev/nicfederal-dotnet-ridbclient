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
    /// Contains information about a tour in RIDB.
    /// </summary>
    [DataContract(Name="Tour")]
    public class RIDBTour
    {
        /// <summary>
        /// The id for the tour.
        /// </summary>
        [DataMember]
        public int TourID;
        
        /// <summary>
        /// The id of the facility with which the tour is associated.
        /// </summary>
        [DataMember]
        public int FacilityID;
        
        /// <summary>
        /// The name of the tour.
        /// </summary>
        [DataMember]
        public string TourName;
        
        /// <summary>
        /// The type of tour.
        /// </summary>
        [DataMember]
        public string TourType;
        
        /// <summary>
        /// A description of the tour.
        /// </summary>
        [DataMember]
        public string TourDescription;
        
        /// <summary>
        /// The duration of the tour.
        /// </summary>
        [DataMember]
        public string TourDuration;
        
        /// <summary>
        /// Information regarding the accessibility of the tour.
        /// </summary>
        [DataMember]
        public string TourAccessible;
        
        /// <summary>
        /// The date the record was created in RIDB.
        /// </summary>
        [DataMember]
        public DateTime? CreatedDate;
        
        /// <summary>
        /// The date the record was last updated in RIDB.
        /// </summary>
        [DataMember]
        public DateTime? LastUpdatedDate;
        
        // RIDB BUG:  The data dictionary is missing the ATTRIBUTES member
        /// <summary>
        /// The attributes associated with the tour.
        /// </summary>
        [DataMember(Name = "ATTRIBUTES")]
        public RIDBAttribute[] Attributes { get; set; }
        
        // RIDB BUG:  The data dictionary is missing the MEMBERTOURS member
        /// <summary>
        /// The member tours associated with the tour.
        /// </summary>
        [DataMember(Name = "MEMBERTOURS")]
        public RIDBMemberTour[] MemberTours { get; set; }
        
        // RIDB BUG:  The data dictionary is missing the ENTITYMEDIA member
        /// <summary>
        /// The media associated with the tour.
        /// </summary>
        [DataMember(Name = "ENTITYMEDIA")]
        public RIDBEntityMedia[] Media { get; set; }
    }
}
