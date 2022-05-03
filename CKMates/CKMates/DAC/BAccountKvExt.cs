﻿using PX.Data;
using PX.Data.BQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKMates.DAC
{
    [PXCacheName("BAccount Attributes")]
    [Serializable]
    public class BAccountKvExt : IBqlTable
    {
        public abstract class recordID : BqlGuid.Field<recordID> { }
        [PXDBGuid(IsKey = true)]
        public Guid? RecordID { get; set; }

        public abstract class fieldName : BqlString.Field<fieldName> { }
        [PXDBString(50, IsKey = true)]
        [PXUIField(DisplayName = "Name")]
        public string FieldName { get; set; }

        public abstract class valueNumeric : BqlDecimal.Field<valueNumeric> { }
        [PXDBDecimal(8)]
        [PXUIField(DisplayName = "Value Numeric")]
        public decimal? ValueNumeric { get; set; }

        public abstract class valueDate : BqlDateTime.Field<valueDate> { }
        [PXDBDate]
        [PXUIField(DisplayName = "Value Date")]
        public DateTime? ValueDate { get; set; }

        public abstract class valueString : BqlString.Field<valueString> { }
        [PXDBString(256)]
        [PXUIField(DisplayName = "Value String")]
        public string ValueString { get; set; }

        public abstract class valueText : BqlString.Field<valueText> { }
        [PXDBString]
        [PXUIField(DisplayName = "Value Text")]
        public string ValueText { get; set; }
    }
}
