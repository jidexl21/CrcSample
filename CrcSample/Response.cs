using System;
using System.Collections.Generic;
using System.Text;

namespace CrcSample
{
    public class CRCResponse
    {
        public Consumerhitresponse ConsumerHitResponse { get; set; }
        public ErrorResponse ErrorResponse { get; set; } = null;
    }

    public class Consumerhitresponse
    {
        public BODY BODY { get; set; }
        public HEADER HEADER { get; set; }
        public string REQUESTID { get; set; }
    }

    public class BODY
    {
        public object AddressHistory { get; set; }
        public object Amount_OD_BucketCURR1 { get; set; }
        public object Amount_OD_BucketCURR2 { get; set; }
        public object Amount_OD_BucketCURR3 { get; set; }
        public object Amount_OD_BucketCURR4 { get; set; }
        public object Amount_OD_BucketCURR5 { get; set; }
        public object CREDIT_SCORE_DETAILS { get; set; }
        public Classificationinstype[] ClassificationInsType { get; set; }
        public Classificationprodtype[] ClassificationProdType { get; set; }
        public object ClosedAccounts { get; set; }
        public Conscommdetails ConsCommDetails { get; set; }
        public object ConsumerMergerDetails { get; set; }
        public object ContactHistory { get; set; }
        public object CreditDisputeDetails { get; set; }
        public object CreditFacilityHistory24 { get; set; }
        public object CreditProfileOverview { get; set; }
        public object CreditProfileSummaryCURR1 { get; set; }
        public object CreditProfileSummaryCURR2 { get; set; }
        public object CreditProfileSummaryCURR3 { get; set; }
        public object CreditProfileSummaryCURR4 { get; set; }
        public object CreditProfileSummaryCURR5 { get; set; }
        public object DMMDisputeSection { get; set; }
        public object DODishonoredChequeDetails { get; set; }
        public object DOJointHolderDetails { get; set; }
        public object DOLitigationDetails { get; set; }
        public Disclaimerdetails DisclaimerDetails { get; set; }
        public object EmploymentHistory { get; set; }
        public object GuaranteedLoanDetails { get; set; }
        public Inquiryhistorydetail[] InquiryHistoryDetails { get; set; }
        public Inquiry_Product[] Inquiry_Product { get; set; }
        public Legenddetails LegendDetails { get; set; }
        public object RelatedToDetails { get; set; }
        public Reportdetail ReportDetail { get; set; }
        public Reportdetailacc ReportDetailAcc { get; set; }
        public Reportdetailbvn ReportDetailBVN { get; set; }
        public Reportdetailmob ReportDetailMob { get; set; }
        public Reportdetailssir ReportDetailsSIR { get; set; }
        public object SecurityDetails { get; set; }
        public Summaryofperformance[] SummaryOfPerformance { get; set; }
    }

    public class Conscommdetails
    {
        public Conscommdetails_ID[] ConsCommDetails_ID { get; set; }
        public Conscommdetails_Subject ConsCommDetails_Subject { get; set; }
    }

    public class Conscommdetails_Subject
    {
        public string ADDRESS { get; set; }
        public string APPLICATIONVIABILITYSCORE { get; set; }
        public string DATE_OF_BIRTH { get; set; }
        public string DATE_OF_BIRTH_M { get; set; }
        public string GENDER { get; set; }
        public string NAME { get; set; }
        public string NATIONALITY { get; set; }
        public string PHONE_NO1 { get; set; }
        public object PHONE_NO2 { get; set; }
    }

    public class Conscommdetails_ID
    {
        public object EXPIRY_DATE { get; set; }
        public string IDENTIFIERNUMBER { get; set; }
        public string IDENTIFIER_NUMBER { get; set; }
        public string ID_TYPE { get; set; }
    }

    public class Disclaimerdetails
    {
    }

    public class Legenddetails
    {
    }

    public class Reportdetail
    {
        public object ReportDetailBVN { get; set; }
    }

    public class Reportdetailacc
    {
        public object ReportDetailAcc { get; set; }
    }

    public class Reportdetailbvn
    {
        public Reportdetailbvn1 ReportDetailBVN { get; set; }
    }

    public class Reportdetailbvn1
    {
        public long BVN_NUMBER { get; set; }
        public string CIR_NUMBER { get; set; }
        public object DATE_OF_BIRTH { get; set; }
        public object DATE_OF_BIRTH_M { get; set; }
        public object GENDER { get; set; }
        public string INSTITUTION_NAME { get; set; }
        public object NAME { get; set; }
        public string REPORT_ORDER_DATE { get; set; }
        public object REPORT_ORDER_DATE_M { get; set; }
        public string SEARCH_CONFIDENCE_SCORE { get; set; }
    }

    public class Reportdetailmob
    {
        public object ReportDetailMob { get; set; }
    }

    public class Reportdetailssir
    {
    }

    public class Classificationinstype
    {
        public string AMOUNT_OVERDUE { get; set; }
        public string APPROVED_CREDIT_SANCTIONED { get; set; }
        public string CURRENCY { get; set; }
        public object ClassificationInsType { get; set; }
        public string INSTITUTION_TYPE { get; set; }
        public string LEGAL_FLAG { get; set; }
        public string NO_OF_ACCOUNTS { get; set; }
        public string OUSTANDING_BALANCE { get; set; }
    }

    public class Classificationprodtype
    {
        public string AMOUNT_OVERDUE { get; set; }
        public string CURRENCY { get; set; }
        public object ClassificationProdType { get; set; }
        public string NO_ACC_LAST_SIX_MON { get; set; }
        public string NO_OF_ACCOUNTS { get; set; }
        public string PRODUCT_TYPE { get; set; }
        public object RECENT_OVERDUE_DATE { get; set; }
        public string SANCTIONED_AMOUNT { get; set; }
        public string TOTAL_OUTSTANDING_BALANCE { get; set; }
    }

    public class Inquiryhistorydetail
    {
        public string FACILITY_TYPE { get; set; }
        public string INQUIRY_DATE { get; set; }
        public string INSTITUTION_TYPE { get; set; }
        public string SNO { get; set; }
    }

    public class Inquiry_Product
    {
        public string BANK { get; set; }
        public string MICRO { get; set; }
        public string MORTGAGE { get; set; }
        public string NBFC { get; set; }
        public string OTHER { get; set; }
        public string PRODUCT_TYPE { get; set; }
        public string TOTAL { get; set; }
    }

    public class Summaryofperformance
    {
        public string ACCOUNT_BALANCE { get; set; }
        public string APPROVED_AMOUNT { get; set; }
        public string DATA_PRDR_ID { get; set; }
        public string DISHONORED_CHEQUES_COUNT { get; set; }
        public string FACILITIES_COUNT { get; set; }
        public string INSTITUTION_NAME { get; set; }
        public string NONPERFORMING_FACILITY { get; set; }
        public string OVERDUE_AMOUNT { get; set; }
        public string PERFORMING_FACILITY { get; set; }
    }

    public class HEADER
    {
        public REPORTHEADER REPORTHEADER { get; set; }
        public RESPONSETYPE RESPONSETYPE { get; set; }
        public SEARCHCRITERIA SEARCHCRITERIA { get; set; }
        public SEARCHRESULTLIST SEARCHRESULTLIST { get; set; }
    }

    public class REPORTHEADER
    {
        public string MAILTO { get; set; }
        public string PRODUCTNAME { get; set; }
        public REASON REASON { get; set; }
        public string REPORTDATE { get; set; }
        public string REPORTORDERNUMBER { get; set; }
        public string USERID { get; set; }
    }

    public class REASON
    {
    }

    public class RESPONSETYPE
    {
        public string CODE { get; set; }
        public string DESCRIPTION { get; set; }
    }

    public class SEARCHCRITERIA
    {
        public object BRANCHCODE { get; set; }
        public string BVN_NO { get; set; }
        public object CFACCOUNTNUMBER { get; set; }
        public object DATEOFBIRTH { get; set; }
        public object GENDER { get; set; }
        public object NAME { get; set; }
        public object TELEPHONE_NO { get; set; }
    }

    public class SEARCHRESULTLIST
    {
        public SEARCHRESULTITEM SEARCHRESULTITEM { get; set; }
    }

    public class SEARCHRESULTITEM
    {
        public ADDRESSES ADDRESSES { get; set; }
        public string BUREAUID { get; set; }
        public string CONFIDENCESCORE { get; set; }
        public IDENTIFIERS IDENTIFIERS { get; set; }
        public string NAME { get; set; }
        public SURROGATES SURROGATES { get; set; }
    }

    public class ADDRESSES
    {
    }

    public class IDENTIFIERS
    {
    }

    public class SURROGATES
    {
    }

}
