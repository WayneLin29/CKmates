using System;
using PX.Data;
using PX.Data.BQL.Fluent;
using PX.Objects.CR;
using PX.TM;
using static PX.Data.PXAccess;

namespace CKMates.DAC
{
    [Serializable]
    [PXCacheName("v_GI_RollingForcastProcessResult")]
    public class v_GI_RollingForcastProcessResult : IBqlTable
    {
        #region Selected
        [PXBool()]
        [PXUIField(DisplayName = "Selected")]
        public virtual bool? Selected { get; set; }
        public abstract class selected : PX.Data.BQL.BqlBool.Field<selected> { }
        #endregion

        #region ForecastType
        [PXDBString(20, InputMask = "",IsKey = true)]
        [PXUIField(DisplayName = "Forecast Type")]
        public virtual string ForecastType { get; set; }
        public abstract class forecastType : PX.Data.BQL.BqlString.Field<forecastType> { }
        #endregion

        #region WorkGroupID
        [PXDBInt(IsKey = true)]
        [PXSelector(typeof(SelectFrom<EPCompanyTree>
                          .InnerJoin<EPCompanyTreeMember>.On<EPCompanyTreeMember.workGroupID.IsEqual<EPCompanyTree.workGroupID>>
                          .InnerJoin<BAccount2>.On<EPCompanyTreeMember.contactID.IsEqual<BAccount2.defContactID>>
                          .InnerJoin<EPEmployee>.On<BAccount2.bAccountID.IsEqual<EPEmployee.bAccountID>>
                          .SearchFor<EPCompanyTree.workGroupID>),
                    SubstituteKey = typeof(EPCompanyTree.description))]
        [PXUIField(DisplayName = "Work Group ID")]
        public virtual int? WorkGroupID { get; set; }
        public abstract class workGroupID : PX.Data.BQL.BqlInt.Field<workGroupID> { }
        #endregion

        #region FinYear
        [PXDBInt(IsKey = true)]
        [PXUIField(DisplayName = "Fin Year")]
        public virtual int? FinYear { get; set; }
        public abstract class finYear : PX.Data.BQL.BqlInt.Field<finYear> { }
        #endregion

        #region SubFinPeriodID
        [PXDBDate(IsKey = true)]
        [PXUIField(DisplayName = "Sub Fin Period ID")]
        public virtual DateTime? SubFinPeriodID { get; set; }
        public abstract class subFinPeriodID : PX.Data.BQL.BqlDateTime.Field<subFinPeriodID> { }
        #endregion

        #region Amount
        [PXDBDecimal()]
        [PXUIField(DisplayName = "Amount")]
        public virtual Decimal? Amount { get; set; }
        public abstract class amount : PX.Data.BQL.BqlDecimal.Field<amount> { }
        #endregion

        #region OrderSeq
        [PXDBInt()]
        [PXUIField(DisplayName = "OrderSeq")]
        public virtual int? OrderSeq { get; set; }
        public abstract class orderSeq : PX.Data.BQL.BqlInt.Field<orderSeq> { }
        #endregion
    }
}