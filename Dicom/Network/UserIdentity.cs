using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dicom.Network
{
    public class UserIdentity
    {
        //密码类型
        public static int USERNAME = 1;

        public static int USERNAME_PASSCODE = 2;

        public static int KERBEROS = 3;

        public static int SAML = 4;

        private int userIdentityType;
        private bool positiveResponseRequested;
        private string username = null;
        private string passcode = null;

        #region Properties
        public string UserName
        {
            get { return username; }
            set { username = value; }
        }
        public string PassCode
        {
            get { return passcode; }
            set { passcode = value; }
        }
        public int UserIdentityType
        {
            get { return userIdentityType; }
            set { userIdentityType = value; }
        }
        public bool bPositiveResponseRequested
        {
            get { return positiveResponseRequested; }
            set { positiveResponseRequested = value; }
        }
        #endregion

        #region Constructors
        public UserIdentity()
        {
            this.username = "zssure";
            this.passcode = "zssure";
            this.positiveResponseRequested = false;
            this.userIdentityType = UserIdentity.USERNAME_PASSCODE;

        }
        public UserIdentity(string user, string passwd)
        {
            this.username = user;
            this.passcode = passwd;
            this.positiveResponseRequested = false;
            this.userIdentityType = UserIdentity.USERNAME_PASSCODE;
        }
        #endregion

    }
}
