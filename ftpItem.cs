using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormFTPEntFile
{
    class ftpItem
    {

        private bool statusflag;

        public bool Statusflag
        {
            get { return statusflag; }
            set { statusflag = value; }
        }

        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        private string address;

        public string ADDRESS
        {
            get { return address; }
            set { address = value; }
        }
        private string username;

        public string USERNAME
        {
            get { return username; }
            set { username = value; }
        }
        private string password;

        public string PSWD
        {
            get { return password; }
            set { password = value; }
        }
        private string reciveunitcode;

        public string RECIVEUNITCODE
        {
            get { return reciveunitcode; }
            set { reciveunitcode = value; }
        }
        private string reciveunitname;

        public string RECIVEUNITNAME
        {
            get { return reciveunitname; }
            set { reciveunitname = value; }
        }
        private string declareunitcode;

        public string DECLAREUNIUTCODE
        {
            get { return declareunitcode; }
            set { declareunitcode = value; }
        }
        private string declareunitname;

        public string DECLAREUNITNAME
        {
            get { return declareunitname; }
            set { declareunitname = value; }
        }
        private string enterprisecode;

        public string ENTERPRISECODE
        {
            get { return enterprisecode; }
            set { enterprisecode = value; }
        }
        private string enterprisename;

        public string ENTERPRISENAME
        {
            get { return enterprisename; }
            set { enterprisename = value; }
        }
        private string templetename;

        public string TEMPLETENAME
        {
            get { return templetename; }
            set { templetename = value; }
        }
        public ftpItem(int id, string address, string username, string password, string reciveunitcode,string reciveunitname,
            string declareunitcode, string declareunitname, string enterprisecode,string enterprisename,string templetename,bool statusflag)
        {
            this.id = id;
            this.address = address;
            this.username = username;
            this.password = password;
            this.reciveunitcode = reciveunitcode;
            this.reciveunitname = reciveunitname;
            this.declareunitcode = declareunitcode;
            this.declareunitname = declareunitname;
            this.enterprisecode = enterprisecode;
            this.enterprisename = enterprisename;
            this.templetename = templetename;
            this.statusflag = statusflag;
        
        }
    }
}
