//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MSGCP
{
    using System;
    using System.Collections.Generic;
    
    public partial class Result
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Result()
        {
            this.ResultTotal = new HashSet<ResultTotal>();
        }
    
        public int result_Id { get; set; }
        public string student_Name { get; set; }
        public string grade { get; set; }
        public Nullable<int> roll_No { get; set; }
        public string section { get; set; }
        public string subject { get; set; }
        public string examination_Type { get; set; }
        public string attendance { get; set; }
        public string remark { get; set; }
        public Nullable<int> marks_Obtained { get; set; }
        public Nullable<int> examination_Id { get; set; }
        public Nullable<int> grade_Id { get; set; }
        public Nullable<int> section_Id { get; set; }
        public Nullable<int> student_Id { get; set; }
        public Nullable<int> remark_id { get; set; }
        public Nullable<int> full_Marks { get; set; }
        public Nullable<int> pass_Marks { get; set; }
        public Nullable<int> SubjectMarks_Id { get; set; }
    
        public virtual Examination Examination { get; set; }
        public virtual Grade Grade1 { get; set; }
        public virtual Remark Remark1 { get; set; }
        public virtual Student Student { get; set; }
        public virtual Section Section1 { get; set; }
        public virtual SubjectMarks SubjectMarks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ResultTotal> ResultTotal { get; set; }
    }
}