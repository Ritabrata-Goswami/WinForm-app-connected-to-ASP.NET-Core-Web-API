using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Runtime.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace UserLoginGUI.CommonCls
{
    public class ShareUserProfile :EventArgs
    {
        public string? UserName { get; set; }
        public string? UserEmail { get; set; }
        public string? UserImage { get; set; }

        public ShareUserProfile()
        {

        }
        public ShareUserProfile(string? Str_UserName, string? Str_UserEmail, string? Str_UserImage)
        {
            UserName = Str_UserName;
            UserEmail = Str_UserEmail;
            UserImage = Str_UserImage;
        }

    }


    public class Cls_Response
    {
        public int Flag { get; set; }
        public int StatusCode { get; set; }
        public string? StatusMessage { get; set; }
    }

    public class Cls_UserLogin
    {
        public string? UserId { get; set; }
        public string? UserPass { get; set; }
    }

    public class Cls_UserAuth
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? UserEmail { get; set; }
        public string? UserGender { get; set; }
        public string? UserImagePath { get; set; }
        public string? AuthToken { get; set; }
    }

    public class ComboItem
    {
        public string? Value { get; set; }
        public string? Text { get; set; }
    }

    public class Cls_ItemPosting
    {
        public int Id { get; set; }
        public string? ItemName { get; set; }
        public decimal ItemPrice { get; set; }
        public string? ItemType { get; set; }
        public string? Tax { get; set; }
    }

    public class Cls_GetItemLists
    {
        public int StatusCode { get; set; }
        public string StatusMessage { get; set; }
        public List<Cls_ItemPosting> ItemListing { get; set; }
    }

}

