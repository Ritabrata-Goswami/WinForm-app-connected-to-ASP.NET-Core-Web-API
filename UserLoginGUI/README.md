## UserLoginGUI Application

A WinForms-based authentication and dashboard application demonstrating a clean, event-driven login flow with session persistence using Properties.Settings.
This project focuses on separation of concerns, custom events, and scalable UI flow, making it a scalable for later integration with ASP.NET Core Web API + ADO.NET + MySQL.

About session persistence the auth token and userid is saved inside application setting.
```
Right Click on project UserLoginGUI
↓
Properties
↓ 
Settings
↓
Click on create or open application settings
```
After that you will see AuthToken and UserId two properties where session data of WinForm is stored.
Which can be read/write by ```Properties.Settings.Default.AuthToken``` and ```Properties.Settings.Default.UserId```.
This two are main points to persists session in Desktop GUI once you logged in just like Web applications.

The project also consists different User Controls like Login.cs, MainHeaderControl.cs, Registration.cs which are assembled into main Form i.e Form1.cs.
By the help of events and event subscriber's we can login to different UserControl name MainAuthScreen.cs.

### The Flow of Login Event
```
Login Button Click
↓
Login (UserControl)
↓ LoginEvent (ShareUserProfile)
MainHeaderControl
↓ Forwarded LoginEvent
Form1
↓
MainAuthScreen Loaded
```
Here ShareUserProfile is a class that is inherited from EventArgs. The class is kept in CommonCls.cs file, something like below,
```
using Microsoft.VisualBasic.ApplicationServices;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace UserLoginGUI.CommonCls
{
    public class ShareUserProfile :EventArgs
    {
        public string? UserName { get; set; }
        public string? UserId { get; set; }

        public ShareUserProfile()
        {

        }
        public ShareUserProfile(string? Str_UserName, string? Str_UserId)
        {
            UserName = Str_UserName;
            UserId = Str_UserId;
        }

    }
}
```
ShareUserProfile class carry user information like UserName and UserId along with Event information. We can get information for both across different screens by the help of this class.
```public event EventHandler<ShareUserProfile> LoginEvent;``` and ```LoginEvent?.Invoke(this, new ShareUserProfile(UserName, UserId));``` for passing the event to another screen with that class.
Check the Login.cs under Login_Click(object sender, EventArgs e) event.

### The Flow of Logout Event
```
Logout Click
↓
MainAuthScreen
↓ LogoutEvent
Form1
↓
MainHeaderControl Restored
```

Backend API is called from ASP.NET Core Web API coupled with MySQL Workbeanch.
