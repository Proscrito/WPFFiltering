using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FilterDataSample.Common;

namespace FilterDataSample.Entities
{
    [Table("Customer", Schema = "SalesLT")]
    public class Customer : CommonBase
    {
        #region Private Variables
        private int? _CustomerID;
        private bool _NameStyle;
        private string _Title;
        private string _FirstName;
        private string _MiddleName;
        private string _LastName;
        private string _Suffix;
        private string _CompanyName;
        private string _SalesPerson;
        private string _EmailAddress;
        private string _Phone;
        private string _PasswordHash;
        private string _PasswordSalt;
        private Guid? _Rowguid;
        private DateTime? _ModifiedDate;
        #endregion

        #region Public Properties
        /// <summary>
        /// Get/Set the CustomerID value
        /// </summary>
        [Required]
        [Key]
        [Display(Description = "Customer ID")]

        public int? CustomerID
        {
            get => _CustomerID;
            set
            {
                _CustomerID = value;
                RaisePropertyChanged("CustomerID");
            }
        }

        /// <summary>
        /// Get/Set the NameStyle value
        /// </summary>

        [Display(Description = "Name Style")]

        public bool NameStyle
        {
            get => _NameStyle;
            set
            {
                _NameStyle = value;

                RaisePropertyChanged("NameStyle");
            }
        }

        /// <summary>
        /// Get/Set the Title value
        /// </summary>

        [Display(Description = "Title")]

        public string Title
        {
            get => _Title;
            set
            {
                _Title = value;

                RaisePropertyChanged("Title");
            }
        }

        /// <summary>
        /// Get/Set the FirstName value
        /// </summary>

        [Display(Description = "First Name")]
        [Required(ErrorMessage = "First Name must be filled in.")]

        public string FirstName
        {
            get => _FirstName;
            set
            {
                _FirstName = value;

                RaisePropertyChanged("FirstName");
            }
        }

        /// <summary>
        /// Get/Set the MiddleName value
        /// </summary>

        [Display(Description = "Middle Name")]

        public string MiddleName
        {
            get => _MiddleName;
            set
            {
                _MiddleName = value;

                RaisePropertyChanged("MiddleName");
            }
        }

        /// <summary>
        /// Get/Set the LastName value
        /// </summary>

        [Display(Description = "Last Name")]
        [Required(ErrorMessage = "Last Name must be filled in.")]

        public string LastName
        {
            get => _LastName;
            set
            {
                _LastName = value;

                RaisePropertyChanged("LastName");
            }
        }

        [NotMapped]
        public string FullName
        {
            get => FirstName + " " + LastName;
            set { var tmp = value; }
        }

        /// <summary>
        /// Get/Set the Suffix value
        /// </summary>

        [Display(Description = "Suffix")]

        public string Suffix
        {
            get => _Suffix;
            set
            {
                _Suffix = value;

                RaisePropertyChanged("Suffix");
            }
        }

        /// <summary>
        /// Get/Set the CompanyName value
        /// </summary>

        [Display(Description = "Company Name")]

        public string CompanyName
        {
            get => _CompanyName;
            set
            {
                _CompanyName = value;

                RaisePropertyChanged("CompanyName");
            }
        }

        /// <summary>
        /// Get/Set the SalesPerson value
        /// </summary>

        [Display(Description = "Sales Person")]

        public string SalesPerson
        {
            get => _SalesPerson;
            set
            {
                _SalesPerson = value;

                RaisePropertyChanged("SalesPerson");
            }
        }

        /// <summary>
        /// Get/Set the EmailAddress value
        /// </summary>

        [Display(Description = "Email Address")]

        public string EmailAddress
        {
            get => _EmailAddress;
            set
            {
                _EmailAddress = value;

                RaisePropertyChanged("EmailAddress");
            }
        }

        /// <summary>
        /// Get/Set the Phone value
        /// </summary>

        [Display(Description = "Phone")]

        public string Phone
        {
            get => _Phone;
            set
            {
                _Phone = value;

                RaisePropertyChanged("Phone");
            }
        }

        /// <summary>
        /// Get/Set the PasswordHash value
        /// </summary>

        [Display(Description = "Password Hash")]
        [Required(ErrorMessage = "Password Hash must be filled in.")]

        public string PasswordHash
        {
            get => _PasswordHash;
            set
            {
                _PasswordHash = value;

                RaisePropertyChanged("PasswordHash");
            }
        }

        /// <summary>
        /// Get/Set the PasswordSalt value
        /// </summary>

        [Display(Description = "Password Salt")]
        [Required(ErrorMessage = "Password Salt must be filled in.")]

        public string PasswordSalt
        {
            get => _PasswordSalt;
            set
            {
                _PasswordSalt = value;

                RaisePropertyChanged("PasswordSalt");
            }
        }

        /// <summary>
        /// Get/Set the rowguid value
        /// </summary>

        [Display(Description = "rowguid")]

        public Guid? Rowguid
        {
            get => _Rowguid;
            set
            {
                _Rowguid = value;

                RaisePropertyChanged("rowguid");
            }
        }

        /// <summary>
        /// Get/Set the ModifiedDate value
        /// </summary>

        [Display(Description = "Modified Date")]
        [Range(typeof(DateTime), "1753-01-01 00:00:00", "9999-12-31 23:59:59", ErrorMessage = "Modified Date must be between {1} and {2}")]

        public DateTime? ModifiedDate
        {
            get => _ModifiedDate;
            set
            {
                _ModifiedDate = value;

                RaisePropertyChanged("ModifiedDate");
            }
        }

        #endregion
    }
}
