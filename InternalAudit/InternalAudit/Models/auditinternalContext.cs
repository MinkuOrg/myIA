using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace InternalAudit.Models
{
    public partial class auditinternalContext : DbContext
    {
        public auditinternalContext()
        {
        }

        public auditinternalContext(DbContextOptions<auditinternalContext> options)
            : base(options)
        {
        }

        //Scaffold-DbContext "server=localhost;port=3306;user=root;password=Google@123;database=auditinternal" MySql.Data.EntityFrameworkCore -OutputDir DataAccess\DataObjects -Tables class,audit_pdl_form_i-f

        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<NoonMealPdlForm13> NoonMealPdlForm13 { get; set; }
        public virtual DbSet<NoonMealPdlForm2> NoonMealPdlForm2 { get; set; }
        public virtual DbSet<NoonMealPdlForm6> NoonMealPdlForm6 { get; set; }
        public virtual DbSet<TblMasterDistrict> TblMasterDistrict { get; set; }
        public virtual DbSet<TblMasterFinancialyear> TblMasterFinancialyear { get; set; }
        public virtual DbSet<TblMasterForms> TblMasterForms { get; set; }
        public virtual DbSet<TblMasterInstitutions> TblMasterInstitutions { get; set; }
        public virtual DbSet<TblMasterPeriod> TblMasterPeriod { get; set; }
        public virtual DbSet<TblMasterPeriodCategory> TblMasterPeriodCategory { get; set; }
        public virtual DbSet<RtiPdl> RtiPdl { get; set; }
        public virtual DbSet<AuditPdlForm1a> AuditPdlForm1a { get; set; }
        public virtual DbSet<AuditPdlFormI> AuditPdlFormI { get; set; }
        public virtual DbSet<Annexure1FormA> Annexure1FormA { get; set; }
        public virtual DbSet<Annexure2FormA> Annexure2FormA { get; set; }
        public virtual DbSet<Annexure3FormA> Annexure3FormA { get; set; }
        public virtual DbSet<Annexure2FormB> Annexure2FormB { get; set; }
        public virtual DbSet<Annexure4FormB> Annexure4FormB { get; set; }
        public virtual DbSet<CommunityFormA> CommunityFormA { get; set; }
        public virtual DbSet<CommunityFormB> CommunityFormB { get; set; }
        public virtual DbSet<CommunityFormC> CommunityFormC { get; set; }
        public virtual DbSet<PdlBoardForm6> PdlBoardForm6 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                 optionsBuilder.UseMySQL("server=localhost;port=3306;user=root;password=Google@123;database=auditinternal");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Login>(entity =>
            {
                entity.ToTable("login", "auditinternal");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NoonMealPdlForm13>(entity =>
            {
                entity.HasKey(e => e.NoonMealRecNo);

                entity.ToTable("noon_meal_pdl_form13", "auditinternal");

                entity.Property(e => e.NoonMealRecNo).HasColumnType("int(11)");

                entity.Property(e => e.AssistantInspector)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AsstDirector)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DeputyInspector)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Inspector)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.JuniorAssistant)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OfficeAssistant)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RecordClerk)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Subject)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Typist)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FormRecNo).HasColumnType("int(11)");
            });

            modelBuilder.Entity<NoonMealPdlForm2>(entity =>
            {
                entity.HasKey(e => e.NoonMealRecNo);

                entity.ToTable("noon_meal_pdl_form2", "auditinternal");

                entity.Property(e => e.NoonMealRecNo).HasColumnType("int(11)");

                entity.Property(e => e.Completed)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.FinancialYear).HasColumnType("int(11)");

                entity.Property(e => e.InstitutionsName).HasColumnType("int(11)");
                  
                entity.Property(e => e.Pending)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Period).HasColumnType("int(11)");   

                entity.Property(e => e.PeriodCategory).HasColumnType("int(11)");


                entity.Property(e => e.TotalCenter).HasColumnType("int(11)");

                entity.Property(e => e.FormRecNo).HasColumnType("int(11)");
            });

            modelBuilder.Entity<NoonMealPdlForm6>(entity =>
            {
                entity.HasKey(e => e.NoonMealRecNo);

                entity.ToTable("noon_meal_pdl_form6", "auditinternal");

                entity.Property(e => e.NoonMealRecNo).HasColumnType("int(11)");

                entity.Property(e => e.Completed)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.FinancialYear).HasColumnType("int(11)");

                entity.Property(e => e.InstitutionsName).HasColumnType("int(11)");

                entity.Property(e => e.Pending)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Period).HasColumnType("int(11)");


                entity.Property(e => e.PeriodCategory).HasColumnType("int(11)");

                entity.Property(e => e.TotalCenter).HasColumnType("int(11)");

                entity.Property(e => e.FormRecNo).HasColumnType("int(11)");
            });

            modelBuilder.Entity<TblMasterDistrict>(entity =>
            {
                entity.HasKey(e => e.DistrictRecNo);

                entity.ToTable("tbl_master_district", "auditinternal");

                entity.Property(e => e.DistrictRecNo).HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.DistrictName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblMasterFinancialyear>(entity =>
            {
                entity.HasKey(e => e.FinancialYearRecNo);

                entity.ToTable("tbl_master_financialyear", "auditinternal");

                entity.Property(e => e.FinancialYearRecNo)
                    .HasColumnName("Financial_Year_Rec_No")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FinancialYear)
                    .HasColumnName("Financial_Year")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblMasterForms>(entity =>
            {
                entity.HasKey(e => e.FormRecNo);

                entity.ToTable("tbl_master_forms", "auditinternal");

                entity.Property(e => e.FormRecNo).HasColumnType("int(11)");

                entity.Property(e => e.FormName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblMasterInstitutions>(entity =>
            {
                entity.HasKey(e => e.InstitutionsRecNo);

                entity.ToTable("tbl_master_institutions", "auditinternal");

                entity.Property(e => e.InstitutionsRecNo)
                    .HasColumnName("Institutions_RecNo")
                    .HasColumnType("int(20)");

                entity.Property(e => e.Contact)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("Created_By")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.District)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EmaiId)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.InstitutionsCategory)
                    .HasColumnName("Institutions_Category")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.InstitutionsDetails)
                    .HasColumnName("Institutions_Details")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.InstitutionsName)
                    .HasColumnName("Institutions_Name")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblMasterPeriod>(entity =>
            {
                entity.HasKey(e => e.PeriodRecNo);

                entity.ToTable("tbl_master_period", "auditinternal");

                entity.Property(e => e.PeriodRecNo).HasColumnType("int(11)");

                entity.Property(e => e.PeriodCategory).HasColumnType("int(11)");

                entity.Property(e => e.PeriodName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblMasterPeriodCategory>(entity =>
            {
                entity.HasKey(e => e.PeriodCategoryRecNo);

                entity.ToTable("tbl_master_period_category", "auditinternal");

                entity.Property(e => e.PeriodCategoryRecNo).HasColumnType("int(11)");

                entity.Property(e => e.PeriodCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RtiPdl>(entity =>
            {
                entity.HasKey(e => e.RtiPdlRecNo);

                entity.ToTable("rti_pdl", "auditinternal");

                entity.Property(e => e.RtiPdlRecNo).HasColumnType("int(11)");
 
                entity.Property(e => e.Details).HasColumnType("int(11)");

                entity.Property(e => e.Appealpetitions).HasColumnType("int(11)");

                entity.Property(e => e.OriginalAppealPetitions).HasColumnType("int(11)");

                entity.Property(e => e.OriginalPetitions).HasColumnType("int(11)");

                entity.Property(e => e.Total).HasColumnType("int(11)");
            });


            modelBuilder.Entity<AuditPdlForm1a>(entity =>
            {
                entity.HasKey(e => e.AuditPdlForm1ArecNo);

                entity.ToTable("audit_pdl_form1a", "auditinternal");

                entity.Property(e => e.AuditPdlForm1ArecNo)
                    .HasColumnName("AuditPdlForm1ARecNo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.District).HasColumnType("int(11)");

                entity.Property(e => e.FinancialYear).HasColumnType("int(11)");

                entity.Property(e => e.InstCompletedThisMonth).HasColumnType("int(11)");

                entity.Property(e => e.InstPendingEndMonth).HasColumnType("int(11)");

                entity.Property(e => e.InstPendingPrevMonth).HasColumnType("int(11)");

                entity.Property(e => e.Institutions).HasColumnType("int(11)");

                entity.Property(e => e.NoOfInstitutions).HasColumnType("int(11)");

                entity.Property(e => e.FormRecNo).HasColumnType("int(11)");
                
            });

            modelBuilder.Entity<AuditPdlFormI>(entity =>
            {
                entity.HasKey(e => e.AuditPdlFormIrecNo);

                entity.ToTable("audit_pdl_form_i", "auditinternal");

                entity.Property(e => e.AuditPdlFormIrecNo)
                    .HasColumnName("AuditPdlFormIRecNo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CentreInstitutionDetails)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.District).HasColumnType("int(11)");

                entity.Property(e => e.FinancialYear).HasColumnType("int(11)");

                entity.Property(e => e.Institutions).HasColumnType("int(11)");

                entity.Property(e => e.PendencyReasons)
                    .HasMaxLength(200)
                    .IsUnicode(false);
                entity.Property(e => e.FormRecNo).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Annexure1FormA>(entity =>
            {
                entity.HasKey(e => e.Annexure1FormArecNo);

                entity.ToTable("annexure_1_form_a", "auditinternal");

                entity.Property(e => e.Annexure1FormArecNo)
                    .HasColumnName("Annexure1FormARecNo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AgricultureExtenCentre)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.District).HasColumnType("int(11)");

                entity.Property(e => e.FinancialYear).HasColumnType("int(11)");

                entity.Property(e => e.PendencyDetail)
                    .HasMaxLength(200)
                    .IsUnicode(false);
                entity.Property(e => e.FormRecNo).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Annexure2FormA>(entity =>
            {
                entity.HasKey(e => e.Annexure2FormArecNo);

                entity.ToTable("annexure_2_form_a", "auditinternal");

                entity.Property(e => e.Annexure2FormArecNo)
                    .HasColumnName("Annexure2FormARecNo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Pendency2013To14)
                    .HasColumnName("Pendency2013To14")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Pendency2014To15)
                    .HasColumnName("Pendency2014To15")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Pendency2015To16)
                    .HasColumnName("Pendency2015To16")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Pendency2016To17)
                    .HasColumnName("Pendency2016To17")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.WeightMeasurementLabour).HasColumnType("int(11)");

                entity.Property(e => e.FormRecNo).HasColumnType("int(11)");
            });


            modelBuilder.Entity<Annexure3FormA>(entity =>
            {
                entity.HasKey(e => e.Annexure3FormArecNo);

                entity.ToTable("annexure_3_form_a", "auditinternal");

                entity.Property(e => e.Annexure3FormArecNo)
                    .HasColumnName("Annexure3FormARecNo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AdministrativeDepartment)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.InstitutionDetails)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Pendency2013To14)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Pendency2014To15)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Pendency2015To16)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Pendency2016To17)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FormRecNo).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Annexure2FormB>(entity =>
            {
                entity.HasKey(e => e.Annexure2FormBrecNo);

                entity.ToTable("annexure_2_form_b", "auditinternal");

                entity.Property(e => e.Annexure2FormBrecNo)
                    .HasColumnName("Annexure2FormBRecNo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AdministrativeDepartment)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AuditFees)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FinancialYear).HasColumnType("int(11)");

                entity.Property(e => e.InstitutionDetails)
                    .HasMaxLength(200)
                    .IsUnicode(false);
                entity.Property(e => e.FormRecNo).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Annexure4FormB>(entity =>
            {
                entity.HasKey(e => e.Annexure4FormBrecNo);

                entity.ToTable("annexure_4_form_b", "auditinternal");

                entity.Property(e => e.Annexure4FormBrecNo)
                    .HasColumnName("Annexure4FormBRecNo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AuditFees)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FinancialYear).HasColumnType("int(11)");

                entity.Property(e => e.Institutions).HasColumnType("int(11)");

                entity.Property(e => e.FormRecNo).HasColumnType("int(11)");
                
            });

            modelBuilder.Entity<CommunityFormA>(entity =>
            {
                entity.HasKey(e => e.CommunityFormArecNo);

                entity.ToTable("community_form_a", "auditinternal");

                entity.Property(e => e.CommunityFormArecNo)
                    .HasColumnName("CommunityFormARecNo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Category)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DistrictOffice)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FormRecNo).HasColumnType("int(11)");

                entity.Property(e => e.Gender)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Grade)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.JoiningDate).HasColumnType("date");

                entity.Property(e => e.OfficerPersonnelsName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PostName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Religion)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CommunityFormB>(entity =>
            {
                entity.HasKey(e => e.CommunityFormBrecNo);

                entity.ToTable("community_form_b", "auditinternal");

                entity.Property(e => e.CommunityFormBrecNo)
                    .HasColumnName("CommunityFormBRecNo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Category)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DistrictOffice)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FormRecNo).HasColumnType("int(11)");

                entity.Property(e => e.Gender)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Grade)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.JoiningDate).HasColumnType("date");

                entity.Property(e => e.OfficerPersonnelsName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PostName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Religion)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CommunityFormC>(entity =>
            {
                entity.HasKey(e => e.CommunityFormCrecNo);

                entity.ToTable("community_form_c", "auditinternal");

                entity.Property(e => e.CommunityFormCrecNo)
                    .HasColumnName("CommunityFormCRecNo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Category)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DistrictOffice)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FormRecNo).HasColumnType("int(11)");

                entity.Property(e => e.Gender)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Grade)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.JoiningDate).HasColumnType("date");

                entity.Property(e => e.OfficerPersonnelsName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PostName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Religion)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PdlBoardForm6>(entity =>
            {
                entity.HasKey(e => e.PdlBoradForm6RecNo);

                entity.ToTable("pdl_board_form_6", "auditinternal");

                entity.Property(e => e.PdlBoradForm6RecNo).HasColumnType("int(11)");

                entity.Property(e => e.AuditWork)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.GovtHoliday)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LeaveAvailed)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NameDesignation)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OfficeWorkBillWork)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OtherDuty)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PensionCertificationWork)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PucWork)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.StaffMeeting)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TotalDays)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });
        }
    }
}
