//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SurveyExportApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class SurveyAnswer
    {
        public long ImageId { get; set; }
        public string NameId { get; set; }
        public byte Answer { get; set; }
        public string Comment { get; set; }
        public System.DateTime Timestamp { get; set; }
    
        public virtual Image Image { get; set; }
    }
}
