### سند جامع سیستم مدیریت مشتریان دانشگاهی

---

### فهرست مطالب

1. **عنوان سیستم**
2. **شرح کلی سیستم**
3. **اشیاء داخلی و خارجی در ارتباط با سیستم**
4. **فعالیت‌های سیستم**
5. **قوانین سیستم**
6. **مشکلات سیستم**
7. **راهکارهای حل مشکلات**
8. **توضیحات کد به زبان فارسی**
   - **مدل‌ها**
     - `Booking.cs`
     - `Provider.cs`
     - `Room.cs`
     - `User.cs`
   - **کلاس‌های کمکی**
     - `EmailHelper.cs`
     - `DatabaseManager.cs`
   - **سرویس‌ها**
     - `RoomService.cs`
     - `UserService.cs`
     - `ProviderService.cs`
     - `BookingService.cs`
   - **فرم‌ها**
     - `RoomDataUpsert.cs`
     - `RoomForm.cs`
     - `UserDataUpsert.cs`
     - `UserForm.cs`
     - `ProviderDataUpsert.cs`
     - `ProviderForm.cs`
     - `ReservationUpsert.cs`
     - `Main.cs`

---

### ۱. **عنوان سیستم**

**سیستم مدیریت مشتریان دانشگاهی**

---

### ۲. **شرح کلی سیستم**

سیستم مدیریت مشتریان دانشگاهی یک ابزار نرم‌افزاری جامع است که با هدف تسهیل مدیریت اطلاعات کاربران، ارائه‌دهندگان خدمات، اتاق‌ها و رزروها طراحی شده است. این سیستم به‌گونه‌ای طراحی شده که امکان ذخیره‌سازی، به‌روزرسانی، مشاهده و حذف داده‌ها را به شیوه‌ای کارآمد و امن فراهم کند. کاربران مختلف می‌توانند از این سیستم برای مدیریت اطلاعات خود استفاده کنند و ارائه‌دهندگان خدمات می‌توانند داده‌های مرتبط با خدمات خود را در آن ثبت و مدیریت کنند. همچنین، این سیستم امکان رزرو و مدیریت زمان‌بندی‌ها را در اختیار کاربران قرار می‌دهد تا فعالیت‌ها به بهترین شکل ممکن سازماندهی شوند.

---

### ۳. **اشیاء داخلی و خارجی در ارتباط با سیستم**

### **اشیاء داخلی**

- **کاربر (User):**  
  این شیء نمایانگر اطلاعات کاربران سیستم است. هر کاربر دارای شناسه منحصربه‌فرد، نام، آدرس ایمیل و شماره تماس است. این اطلاعات به‌عنوان بخش اصلی تعامل با سیستم عمل می‌کنند و برای شناسایی و مدیریت کاربران استفاده می‌شوند.

- **ارائه‌دهنده خدمات (Provider):**  
  ارائه‌دهندگان خدمات در سیستم به‌عنوان یک شیء جداگانه ذخیره می‌شوند. هر ارائه‌دهنده دارای اطلاعاتی نظیر نام، نوع خدمات، شماره تماس و آدرس ایمیل است. این شیء امکان مدیریت خدمات ارائه‌شده و ارتباط با کاربران را فراهم می‌کند.

- **رزرو (Booking):**  
  رزروها به‌عنوان اشیائی برای ذخیره اطلاعات مربوط به زمان‌بندی‌ها و تعاملات بین کاربران و ارائه‌دهندگان تعریف شده‌اند. این شیء شامل اطلاعاتی مانند شناسه کاربر، شناسه ارائه‌دهنده، شناسه اتاق و بازه زمانی رزرو است.

- **اتاق (Room):**  
  این شیء نماینده اتاق‌های قابل رزرو است. اطلاعات هر اتاق شامل شماره، نوع، وضعیت دسترسی و سایر مشخصات مرتبط است که به سیستم کمک می‌کند رزروها را به‌درستی مدیریت کند.

### **اشیاء خارجی**

- **پایگاه داده (Database):**  
  پایگاه داده بخش خارجی سیستم است که تمامی اطلاعات کاربران، ارائه‌دهندگان، رزروها و اتاق‌ها در آن ذخیره می‌شود. این بخش مسئول نگهداری ایمن داده‌ها و بازیابی سریع آن‌ها برای استفاده در بخش‌های مختلف سیستم است.

- **ایمیل (Email):**  
  سیستم از ایمیل به‌عنوان یک ابزار خارجی برای ارتباط با کاربران و ارائه‌دهندگان استفاده می‌کند. ارسال اعلان‌های مرتبط با رزرو، تأییدیه‌ها و اطلاع‌رسانی‌های دیگر از طریق این ابزار انجام می‌شود.

- **رابط کاربری (User Interface):**  
  این بخش نمایانگر فرم‌ها و بخش‌هایی است که کاربران از طریق آن‌ها با سیستم تعامل می‌کنند. رابط کاربری شامل فرم‌های ورود اطلاعات، صفحات مدیریت داده‌ها و نمایش گزارش‌ها است.

---

### ۴. **فعالیت‌های سیستم**

1. **ایجاد کاربران جدید:**  
   این سیستم امکان ثبت اطلاعات کاربران جدید را فراهم می‌کند. داده‌هایی همچون نام، شماره تماس و آدرس ایمیل در این فرآیند ثبت می‌شوند.

2. **مدیریت ارائه‌دهندگان خدمات:**  
   از طریق این سیستم می‌توان اطلاعات مربوط به ارائه‌دهندگان خدمات را ذخیره، به‌روزرسانی یا حذف کرد.

3. **رزرو و زمان‌بندی:**  
   کاربران می‌توانند از سیستم برای ثبت رزرو‌های جدید استفاده کنند. اطلاعات مرتبط با کاربر، ارائه‌دهنده، اتاق و زمان رزرو در این فرآیند ذخیره می‌شوند.

4. **مدیریت اتاق‌ها:**  
   سیستم امکان مدیریت اطلاعات اتاق‌ها، بررسی وضعیت دسترسی آن‌ها و به‌روزرسانی اطلاعات مربوطه را فراهم می‌کند.

5. **ارسال اعلان‌ها:**  
   این سیستم قادر است اطلاعیه‌های مرتبط با رزروها یا تغییرات را از طریق ایمیل به کاربران ارسال کند.

---

### ۵. **قوانین سیستم**

1. تمامی داده‌های ورودی باید معتبر باشند و سیستم از ولیدیشن‌های مختلف برای اطمینان از صحت داده‌ها استفاده می‌کند.
2. فقط کاربران مجاز می‌توانند به اطلاعات خاص دسترسی داشته باشند.
3. هر رزرو باید با شناسه‌های کاربر، ارائه‌دهنده و اتاق معتبر ذخیره شود.
4. اطلاعات ذخیره‌شده باید به‌صورت منظم در پایگاه داده پشتیبان‌گیری شوند.

---

### ۶. **مشکلات سیستم**

- **ضعف در ولیدیشن داده‌ها:** در صورتی که داده‌های نامعتبر وارد سیستم شوند، ممکن است مشکلاتی در عملکرد سیستم ایجاد شود.
- **کندی در عملکرد:** با افزایش حجم داده‌ها، ممکن است سرعت پاسخ‌گویی سیستم کاهش یابد.
- **مشکلات امنیتی:** در صورت نبود تدابیر امنیتی مناسب، امکان نفوذ و دسترسی غیرمجاز وجود دارد.
- **قطعی ارتباط با پایگاه داده:** هرگونه مشکل در اتصال به پایگاه داده می‌تواند عملکرد سیستم را مختل کند.

---

### ۷. **راهکارهای حل مشکلات**

- **تقویت ولیدیشن داده‌ها:** استفاده از اعتبارسنجی‌های قوی برای جلوگیری از ورود داده‌های نامعتبر.
- **بهینه‌سازی پایگاه داده:** به‌کارگیری روش‌های بهینه برای مدیریت داده‌ها و افزایش سرعت سیستم.
- **افزایش امنیت سیستم:** پیاده‌سازی رمزنگاری داده‌ها و مدیریت دسترسی کاربران برای حفاظت از اطلاعات.
- **پایداری در اتصال به پایگاه داده:** استفاده از تکنولوژی‌هایی که ارتباطات پایدار و مطمئن با پایگاه داده را تضمین می‌کنند.

---

### ۸. **توضیحات کد به زبان فارسی**

### **مدل‌ها**

1. **`Booking.cs`:**  
   این کلاس نماینده یک رزرو در سیستم است. هر رزرو شامل اطلاعاتی مانند شناسه کاربر، ارائه‌دهنده، اتاق و زمان‌بندی است.

2. **`Provider.cs`:**  
   این کلاس نماینده یک ارائه‌دهنده خدمات در سیستم است. هر ارائه‌دهنده شامل اطلاعاتی مانند نام، نوع خدمات، شماره تماس و آدرس ایمیل است.

3. **`Room.cs`:**  
   این کلاس نماینده یک اتاق در سیستم است. هر اتاق شامل اطلاعاتی مانند نام و مکان است.

4. **`User.cs`:**  
   این کلاس نماینده یک کاربر در سیستم است. هر کاربر شامل اطلاعاتی مانند نام، شماره تماس و آدرس ایمیل است.

### **کلاس‌های کمکی**

1. **`EmailHelper.cs`:**  
   این کلاس برای ارسال ایمیل‌ها در سیستم استفاده می‌شود. از این کلاس می‌توان برای ارسال ایمیل‌های تأییدیه و اطلاع‌رسانی استفاده کرد.

2. **`DatabaseManager.cs`:**  
   این کلاس برای مدیریت ارتباط با پایگاه داده SQLite طراحی شده است. این کلاس امکان اجرای کوئری‌ها و دستورات غیرکوئری را فراهم می‌کند.

### **سرویس‌ها**

1. **`RoomService.cs`:**  
   این کلاس برای مدیریت عملیات مربوط به اتاق‌ها در سیستم طراحی شده است.

2. **`UserService.cs`:**  
   این کلاس برای مدیریت عملیات مربوط به کاربران در سیستم طراحی شده است.

3. **`ProviderService.cs`:**  
   این کلاس برای مدیریت عملیات مربوط به ارائه‌دهندگان خدمات در سیستم طراحی شده است.

4. **`BookingService.cs`:**  
   این کلاس برای مدیریت عملیات مربوط به رزروها در سیستم طراحی شده است.

### **فرم‌ها**

1. **`RoomDataUpsert.cs`:**  
   این فرم برای افزودن یا به‌روزرسانی اطلاعات اتاق‌ها استفاده می‌شود.

2. **`RoomForm.cs`:**  
   این فرم برای مدیریت کامل اتاق‌ها در سیستم استفاده می‌شود.

3. **`UserDataUpsert.cs`:**  
   این فرم برای افزودن یا به‌روزرسانی اطلاعات کاربران استفاده می‌شود.

4. **`UserForm.cs`:**  
   این فرم برای مدیریت کامل کاربران در سیستم استفاده می‌شود.

5. **`ProviderDataUpsert.cs`:**  
   این فرم برای افزودن یا به‌روزرسانی اطلاعات ارائه‌دهندگان خدمات استفاده می‌شود.

6. **`ProviderForm.cs`:**  
   این فرم برای مدیریت کامل ارائه‌دهندگان خدمات در سیستم استفاده می‌شود.

7. **`ReservationUpsert.cs`:**  
   این فرم برای افزودن یا به‌روزرسانی رزروها استفاده می‌شود.

8. **`Main.cs`:**  
   این فرم اصلی سیستم است که امکان مدیریت رزروها و دسترسی به سایر فرم‌ها را فراهم می‌کند.

## مدل ها

### ۱. **مدل `Booking.cs`**

```csharp
using System;

namespace Customer_Management_Uni.Models
{
    public class Booking
    {
        public int booking_id { get; set; }
        public int user_id { get; set; }
        public int provider_id { get; set; }
        public int room_id { get; set; }
        public DateTime start_time { get; set; }
        public DateTime end_time { get; set; }
    }
}
```

### توضیحات:

- **فضای نام (Namespace):**  
  این کلاس در فضای نام `Customer_Management_Uni.Models` قرار دارد. فضای نام به سازمان‌دهی کدها کمک می‌کند و از تداخل نام‌ها جلوگیری می‌نماید.

- **کلاس `Booking`:**  
  این کلاس نماینده یک رزرو در سیستم است. هر رزرو شامل اطلاعاتی است که برای مدیریت زمان‌بندی و تعاملات بین کاربران، ارائه‌دهندگان و اتاق‌ها استفاده می‌شود.

- **ویژگی‌ها (Properties):**

  - `booking_id`: شناسه منحصربه‌فرد رزرو.
  - `user_id`: شناسه کاربری که رزرو را انجام داده است.
  - `provider_id`: شناسه ارائه‌دهنده‌ای که خدمات را ارائه می‌دهد.
  - `room_id`: شناسه اتاقی که رزرو شده است.
  - `start_time`: زمان شروع رزرو.
  - `end_time`: زمان پایان رزرو.

- **نکات طراحی:**
  - از نوع `DateTime` برای زمان‌ها استفاده شده است که دقت و قابلیت مدیریت زمان‌بندی را افزایش می‌دهد.
  - هر رزرو با شناسه‌های کاربر، ارائه‌دهنده و اتاق مرتبط است که این ارتباطات را در سیستم مدیریت می‌کند.

---

### ۲. **مدل `Provider.cs`**

```csharp
using System.ComponentModel.DataAnnotations;

namespace Customer_Management_Uni.Models
{
    public class Provider
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ServiceType { get; set; }
        public string Number { get; set; }
        [EmailAddress]
        public string EmailAddress { get; set; }
    }
}
```

### توضیحات:

- **فضای نام (Namespace):**  
  این کلاس نیز در فضای نام `Customer_Management_Uni.Models` قرار دارد.

- **کلاس `Provider`:**  
  این کلاس نماینده یک ارائه‌دهنده خدمات در سیستم است. ارائه‌دهندگان می‌توانند سازمان‌ها یا افرادی باشند که خدمات خاصی را به کاربران ارائه می‌دهند.

- **ویژگی‌ها (Properties):**

  - `Id`: شناسه منحصربه‌فرد ارائه‌دهنده.
  - `Name`: نام ارائه‌دهنده.
  - `ServiceType`: نوع خدماتی که ارائه‌دهنده ارائه می‌دهد.
  - `Number`: شماره تماس ارائه‌دهنده.
  - `EmailAddress`: آدرس ایمیل ارائه‌دهنده.

- **اعتبارسنجی (Validation):**

  - از ویژگی `[EmailAddress]` برای اعتبارسنجی فرمت ایمیل استفاده شده است. این ویژگی اطمینان می‌دهد که ایمیل وارد شده معتبر باشد.

- **نکات طراحی:**
  - این مدل برای مدیریت اطلاعات ارائه‌دهندگان طراحی شده است و امکان ثبت و به‌روزرسانی اطلاعات آن‌ها را فراهم می‌کند.

---

### ۳. **مدل `Room.cs`**

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Management_Uni.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
    }
}
```

### توضیحات:

- **فضای نام (Namespace):**  
  این کلاس در فضای نام `Customer_Management_Uni.Models` قرار دارد.

- **کلاس `Room`:**  
  این کلاس نماینده یک اتاق در سیستم است. اتاق‌ها می‌توانند برای رزرو توسط کاربران استفاده شوند.

- **ویژگی‌ها (Properties):**

  - `Id`: شناسه منحصربه‌فرد اتاق.
  - `Name`: نام اتاق.
  - `Location`: مکان اتاق.

- **نکات طراحی:**
  - این مدل برای مدیریت اطلاعات اتاق‌ها طراحی شده است و امکان ثبت و به‌روزرسانی اطلاعات آن‌ها را فراهم می‌کند.

---

### ۴. **مدل `User.cs`**

```csharp
using System.ComponentModel.DataAnnotations;

namespace Customer_Management_Uni.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [EmailAddress]
        public string EmailAddress { get; set; }
        public string Number { get; set; }
    }
}
```

### توضیحات:

- **فضای نام (Namespace):**  
  این کلاس در فضای نام `Customer_Management_Uni.Models` قرار دارد.

- **کلاس `User`:**  
  این کلاس نماینده یک کاربر در سیستم است. کاربران می‌توانند دانشجویان، اساتید یا کارمندان باشند که از سیستم استفاده می‌کنند.

- **ویژگی‌ها (Properties):**

  - `Id`: شناسه منحصربه‌فرد کاربر.
  - `Name`: نام کاربر.
  - `EmailAddress`: آدرس ایمیل کاربر.
  - `Number`: شماره تماس کاربر.

- **اعتبارسنجی (Validation):**

  - از ویژگی `[EmailAddress]` برای اعتبارسنجی فرمت ایمیل استفاده شده است. این ویژگی اطمینان می‌دهد که ایمیل وارد شده معتبر باشد.

- **نکات طراحی:**
  - این مدل برای مدیریت اطلاعات کاربران طراحی شده است و امکان ثبت و به‌روزرسانی اطلاعات آن‌ها را فراهم می‌کند.

---

### **جمع‌بندی**

مدل‌های ارائه شده (`Booking`, `Provider`, `Room`, `User`) هسته اصلی سیستم مدیریت مشتریان دانشگاهی را تشکیل می‌دهند. هر مدل نماینده یک موجودیت در سیستم است و ویژگی‌های آن موجودیت را تعریف می‌کند. این مدل‌ها به‌گونه‌ای طراحی شده‌اند که امکان مدیریت داده‌ها را به‌صورت کارآمد و ساختارمند فراهم کنند. اعتبارسنجی‌های استفاده شده نیز اطمینان می‌دهند که داده‌های وارد شده معتبر و قابل اعتماد باشند.

## ابزار های کمکی

### ۱. **کلاس `EmailHelper.cs`**

```csharp
using System;
using System.Net;
using System.Net.Mail;

namespace Customer_Management_Uni.Utils
{
    public class EmailHelper
    {
        private readonly string _smtpServer;
        private readonly int _smtpPort;
        private readonly string _smtpUsername;
        private readonly string _smtpPassword;
        private readonly bool _enableSsl;

        public EmailHelper(string smtpServer, int smtpPort, string smtpUsername, string smtpPassword, bool enableSsl = true)
        {
            _smtpServer = smtpServer ?? throw new ArgumentNullException(nameof(smtpServer));
            _smtpPort = smtpPort;
            _smtpUsername = smtpUsername ?? throw new ArgumentNullException(nameof(smtpUsername));
            _smtpPassword = smtpPassword ?? throw new ArgumentNullException(nameof(smtpPassword));
            _enableSsl = enableSsl;
        }

        public void SendEmail(string to, string subject, string body)
        {
            try
            {
                using (var client = new SmtpClient(_smtpServer, _smtpPort))
                {
                    client.Credentials = new NetworkCredential(_smtpUsername, _smtpPassword);
                    client.EnableSsl = _enableSsl;

                    var mailMessage = new MailMessage
                    {
                        From = new MailAddress(_smtpUsername),
                        Subject = subject,
                        Body = body,
                        IsBodyHtml = false // Set to true if you want to send HTML emails
                    };
                    mailMessage.To.Add(to);

                    client.Send(mailMessage);
                }
            }
            catch (Exception ex)
            {
                // Log the exception (you can replace this with your logging mechanism)
                Console.WriteLine($"Failed to send email: {ex.Message}");
                throw; // Re-throw the exception if you want the caller to handle it
            }
        }

        public void NotifyBooking(string userEmail, string roomName, DateTime start, DateTime end)
        {
            var subject = "Booking Confirmation";
            var body = $"Your booking for {roomName} is confirmed from {start:yyyy-MM-dd HH:mm} to {end:yyyy-MM-dd HH:mm}.";
            SendEmail(userEmail, subject, body);
        }
    }
}
```

### توضیحات:

- **کتابخانه ها:**

- **فضای نام (Namespace):**  
  این کلاس در فضای نام `Customer_Management_Uni.Utils` قرار دارد.

- **کلاس `EmailHelper`:**  
  این کلاس برای ارسال ایمیل‌ها در سیستم طراحی شده است. از این کلاس می‌توان برای ارسال ایمیل‌های مختلف مانند تأییدیه‌ها و اطلاع‌رسانی‌ها استفاده کرد.

- **ویژگی‌ها (Properties):**

  - `_smtpServer`: آدرس سرور SMTP برای ارسال ایمیل.
  - `_smtpPort`: پورت سرور SMTP.
  - `_smtpUsername`: نام کاربری برای احراز هویت در سرور SMTP.
  - `_smtpPassword`: رمز عبور برای احراز هویت در سرور SMTP.
  - `_enableSsl`: فعال‌سازی SSL برای اتصال امن به سرور SMTP.

- **متد `SendEmail`:**  
  این متد برای ارسال ایمیل به یک آدرس مشخص استفاده می‌شود. پارامترهای آن شامل آدرس ایمیل گیرنده (`to`)، موضوع ایمیل (`subject`) و متن ایمیل (`body`) است. در صورت بروز خطا، خطا در کنسول ثبت شده و به caller ارسال می‌شود.

- **متد `NotifyBooking`:**  
  این متد برای ارسال ایمیل تأیید رزرو به کاربر استفاده می‌شود. پارامترهای آن شامل آدرس ایمیل کاربر (`userEmail`)، نام اتاق (`roomName`)، زمان شروع (`start`) و زمان پایان (`end`) رزرو است.

- **نکات طراحی:**
  - از کلاس `SmtpClient` برای ارسال ایمیل استفاده شده است.
  - امکان ارسال ایمیل‌های HTML با تغییر مقدار `IsBodyHtml` به `true` وجود دارد.
  - خطاها در کنسول ثبت می‌شوند، اما می‌توان از یک سیستم لاگ‌گیری پیشرفته‌تر استفاده کرد.

---

### ۲. **کلاس `DatabaseManager.cs`**

```csharp
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace Customer_Management_Uni.Utils
{
    public class DatabaseManager
    {
        private SQLiteConnection connection;

        private const string connectionString = "Data Source=..\\..\\database.db;Version=3;Pooling=True;Max Pool Size=100;";

        public DatabaseManager()
        {
            connection = new SQLiteConnection(connectionString);
            connection.Open();
        }

        public void ExecuteNonQuery(string query, Dictionary<string, object> parameters)
        {
            using (var cmd = new SQLiteCommand(query, connection))
            {
                AddParameters(cmd, parameters);
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable ExecuteQuery(string query, Dictionary<string, object> parameters = null)
        {
            var results = new List<Dictionary<string, object>>();

            using (var cmd = new SQLiteCommand(query, connection))
            {
                if (parameters != null)
                {
                    AddParameters(cmd, parameters);
                }

                using (var adapter = new SQLiteDataAdapter(cmd))
                {
                    var dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

        private void AddParameters(SQLiteCommand cmd, Dictionary<string, object> parameters)
        {
            foreach (var param in parameters)
            {
                cmd.Parameters.AddWithValue(param.Key, param.Value);
            }
        }

        public void Dispose()
        {
            if (connection != null)
            {
                connection.Close();
                connection.Dispose();
            }
        }
    }
}
```

### توضیحات:

- **فضای نام (Namespace):**  
  این کلاس در فضای نام `Customer_Management_Uni.Utils` قرار دارد.
- **‌کتابخانه ها:**

- **کلاس `DatabaseManager`:**  
  این کلاس برای مدیریت ارتباط با پایگاه داده SQLite طراحی شده است. این کلاس امکان اجرای کوئری‌ها و دستورات غیرکوئری (مانند INSERT, UPDATE, DELETE) را فراهم می‌کند.

- **ویژگی‌ها (Properties):**

  - `connection`: اتصال به پایگاه داده SQLite.
  - `connectionString`: رشته اتصال به پایگاه داده که شامل مسیر فایل پایگاه داده و تنظیمات مربوطه است.

- **متد `ExecuteNonQuery`:**  
  این متد برای اجرای دستورات غیرکوئری (مانند INSERT, UPDATE, DELETE) استفاده می‌شود. پارامترهای آن شامل کوئری (`query`) و پارامترهای کوئری (`parameters`) است.

- **متد `ExecuteQuery`:**  
  این متد برای اجرای کوئری‌های SELECT و دریافت نتایج به‌صورت `DataTable` استفاده می‌شود. پارامترهای آن شامل کوئری (`query`) و پارامترهای کوئری (`parameters`) است.

- **متد `AddParameters`:**  
  این متد برای افزودن پارامترها به دستور SQLite استفاده می‌شود. پارامترهای آن شامل دستور SQLite (`cmd`) و پارامترها (`parameters`) است.

- **متد `Dispose`:**  
  این متد برای بستن و آزادسازی منابع اتصال به پایگاه داده استفاده می‌شود.

- **نکات طراحی:**
  - از `SQLiteConnection` برای مدیریت اتصال به پایگاه داده استفاده شده است.
  - از `SQLiteCommand` برای اجرای دستورات SQL استفاده شده است.
  - از `SQLiteDataAdapter` برای پر کردن `DataTable` با نتایج کوئری استفاده شده است.
  - امکان استفاده از پارامترها برای جلوگیری از حملات تزریق SQL وجود دارد.

---

### **جمع‌بندی**

کلاس‌های `EmailHelper` و `DatabaseManager` به‌عنوان ابزارهای کمکی در سیستم مدیریت مشتریان دانشگاهی استفاده می‌شوند. `EmailHelper` برای ارسال ایمیل‌ها و `DatabaseManager` برای مدیریت ارتباط با پایگاه داده طراحی شده‌اند. این کلاس‌ها به‌گونه‌ای طراحی شده‌اند که امکان استفاده مجدد و مدیریت آسان را فراهم کنند.

## سرویس ها

1. **کلاس `RoomService.cs`**
2. **کلاس `UserService.cs`**
3. **کلاس `ProviderService.cs`**
4. **کلاس `BookingService.cs`**

---

### ۱. **کلاس `RoomService.cs`**

```csharp
using System.Data;
using System.Collections.Generic;

namespace Customer_Management_Uni.Services
{
    using Customer_Management_Uni.Models;
    using Customer_Management_Uni.Utils;
    public class RoomService
    {
        private readonly DatabaseManager _database;

        public RoomService(DatabaseManager database)
        {
            _database = database;
        }

        public void Add(Room room)
        {
            string query = "INSERT INTO Rooms (Name,  Location) VALUES (@Name,  @Location);";
            var parameters = new Dictionary<string, object>
        {
            { "@Name", room.Name },
            { "@Location", room.Location }
        };
            _database.ExecuteNonQuery(query, parameters);
        }

        public DataTable GetAll()
        {
            string query = "SELECT * FROM Rooms;";
            var results = _database.ExecuteQuery(query);

            return results;
        }

        public void Update(int id, Room room)
        {
            string query = "UPDATE Rooms SET Name = @Name,  Location = @Location WHERE Id = @Id;";
            var parameters = new Dictionary<string, object>
        {
            { "@Name", room.Name },
            { "@Location", room.Location },
            { "@Id", id }
        };
            _database.ExecuteNonQuery(query, parameters);
        }

        public void Delete(int id)
        {
            string query = "DELETE FROM Rooms WHERE Id = @Id;";
            var parameters = new Dictionary<string, object> { { "@Id", id } };
            _database.ExecuteNonQuery(query, parameters);
        }

        private Room MapToRoom(DataRow row)
        {
            return new Room
            {
                Id = (int)row["Id"],
                Name = row["Name"].ToString(),
                Location = row["Location"].ToString()
            };
        }
    }
}
```

### توضیحات:

- **فضای نام (Namespace):**  
  این کلاس در فضای نام `Customer_Management_Uni.Services` قرار دارد.

- **کلاس `RoomService`:**  
  این کلاس برای مدیریت عملیات مربوط به اتاق‌ها در سیستم طراحی شده است. این کلاس از `DatabaseManager` برای تعامل با پایگاه داده استفاده می‌کند.

- **متد `Add`:**  
  این متد برای افزودن یک اتاق جدید به پایگاه داده استفاده می‌شود. پارامترهای آن شامل شیء `Room` است که اطلاعات اتاق را در خود نگه می‌دارد.

- **متد `GetAll`:**  
  این متد برای دریافت تمامی اتاق‌ها از پایگاه داده استفاده می‌شود. نتایج به‌صورت `DataTable` بازگردانده می‌شوند.

- **متد `Update`:**  
  این متد برای به‌روزرسانی اطلاعات یک اتاق موجود در پایگاه داده استفاده می‌شود. پارامترهای آن شامل شناسه اتاق (`id`) و شیء `Room` با اطلاعات جدید است.

- **متد `Delete`:**  
  این متد برای حذف یک اتاق از پایگاه داده استفاده می‌شود. پارامتر آن شناسه اتاق (`id`) است.

- **متد `MapToRoom`:**  
  این متد برای تبدیل یک سطر از `DataRow` به شیء `Room` استفاده می‌شود.

---

### ۲. **کلاس `UserService.cs`**

```csharp
using Customer_Management_Uni.Models;
using Customer_Management_Uni.Utils;
using System.Collections.Generic;
using System.Data;

namespace Customer_Management_Uni.Services
{
    public class UserService
    {
        private readonly DatabaseManager _database;

        public UserService(DatabaseManager database)
        {
            _database = database;
        }

        public void Add(User user)
        {
            string query = "INSERT INTO Users (Name, Number , email_address) VALUES (@Name,@Number ,  @Email);";
            var parameters = new Dictionary<string, object>
        {
            { "@Name", user.Name },
            { "@Email", user.EmailAddress },
            { "@Number", user.Number },
        };
            _database.ExecuteNonQuery(query, parameters);
        }

        public DataTable GetAll()
        {
            string query = "SELECT * FROM Users;";
            var results = _database.ExecuteQuery(query);

            return results;
        }

        public void Update(int id, User user)
        {
            string query = "UPDATE Users SET Name = @Name, email_address = @Email WHERE Id = @Id;";
            var parameters = new Dictionary<string, object>
        {
            { "@Name", user.Name },
            { "@Email", user.EmailAddress },
            { "@Number", user.Number },
            { "@Id", id }
        };
            _database.ExecuteNonQuery(query, parameters);
        }

        public void Delete(int id)
        {
            string query = "DELETE FROM Users WHERE Id = @Id;";
            var parameters = new Dictionary<string, object> { { "@Id", id } };
            _database.ExecuteNonQuery(query, parameters);
        }

        private User MapToUser(DataRow row)
        {
            return new User
            {
                Id = (int)row["Id"],
                Name = row["Name"].ToString(),
                Number = row["Number"].ToString(),
                EmailAddress = row["email_address"].ToString()
            };
        }
    }
}
```

### توضیحات:

- **فضای نام (Namespace):**  
  این کلاس در فضای نام `Customer_Management_Uni.Services` قرار دارد.

- **کلاس `UserService`:**  
  این کلاس برای مدیریت عملیات مربوط به کاربران در سیستم طراحی شده است. این کلاس از `DatabaseManager` برای تعامل با پایگاه داده استفاده می‌کند.

- **متد `Add`:**  
  این متد برای افزودن یک کاربر جدید به پایگاه داده استفاده می‌شود. پارامترهای آن شامل شیء `User` است که اطلاعات کاربر را در خود نگه می‌دارد.

- **متد `GetAll`:**  
  این متد برای دریافت تمامی کاربران از پایگاه داده استفاده می‌شود. نتایج به‌صورت `DataTable` بازگردانده می‌شوند.

- **متد `Update`:**  
  این متد برای به‌روزرسانی اطلاعات یک کاربر موجود در پایگاه داده استفاده می‌شود. پارامترهای آن شامل شناسه کاربر (`id`) و شیء `User` با اطلاعات جدید است.

- **متد `Delete`:**  
  این متد برای حذف یک کاربر از پایگاه داده استفاده می‌شود. پارامتر آن شناسه کاربر (`id`) است.

- **متد `MapToUser`:**  
  این متد برای تبدیل یک سطر از `DataRow` به شیء `User` استفاده می‌شود.

---

### ۳. **کلاس `ProviderService.cs`**

```csharp
using System.Data;

namespace Customer_Management_Uni.Services
{
    using Customer_Management_Uni.Models;
    using Customer_Management_Uni.Utils;
    using System.Collections.Generic;

    public class ProviderService
    {
        private readonly DatabaseManager _database;

        public ProviderService(DatabaseManager database)
        {
            _database = database;
        }

        public void Add(Provider provider)
        {
            string query = "INSERT INTO Providers (Name, service_type, email_address,Number) VALUES (@Name, @ServiceType,@EmailAddress ,@Number);";
            var parameters = new Dictionary<string, object>
        {
            { "@Name", provider.Name },
            { "@ServiceType", provider.ServiceType },
            { "@Number", provider.Number },
            { "@EmailAddress", provider.EmailAddress }
        };
            _database.ExecuteNonQuery(query, parameters);
        }

        public DataTable GetAll()
        {
            string query = "SELECT * FROM Providers;";
            var results = _database.ExecuteQuery(query);

            return results;
        }

        public void Update(int id, Provider provider)
        {
            string query = "UPDATE Providers SET Name = @Name, service_type = @ServiceType, Number = @Number , email_address = @EmailAddress WHERE Id = @Id;";
            var parameters = new Dictionary<string, object>
        {
            { "@Name", provider.Name },
            { "@ServiceType", provider.ServiceType },
            { "@Number", provider.Number },
            { "@EmailAddress", provider.EmailAddress },
            { "@Id", id }
        };
            _database.ExecuteNonQuery(query, parameters);
        }

        public void Delete(int id)
        {
            string query = "DELETE FROM Providers WHERE Id = @Id;";
            var parameters = new Dictionary<string, object> { { "@Id", id } };
            _database.ExecuteNonQuery(query, parameters);
        }

        private Provider MapToProvider(DataRow row)
        {
            return new Provider
            {
                Id = (int)row["Id"],
                Name = row["Name"].ToString(),
                ServiceType = row["ServiceType"].ToString(),
                Number = row["Number"].ToString(),
                @EmailAddress = row["EmailAddress"].ToString()
            };
        }
    }
}
```

### توضیحات:

- **فضای نام (Namespace):**  
  این کلاس در فضای نام `Customer_Management_Uni.Services` قرار دارد.

- **کلاس `ProviderService`:**  
  این کلاس برای مدیریت عملیات مربوط به ارائه‌دهندگان خدمات در سیستم طراحی شده است. این کلاس از `DatabaseManager` برای تعامل با پایگاه داده استفاده می‌کند.

- **متد `Add`:**  
  این متد برای افزودن یک ارائه‌دهنده جدید به پایگاه داده استفاده می‌شود. پارامترهای آن شامل شیء `Provider` است که اطلاعات ارائه‌دهنده را در خود نگه می‌دارد.

- **متد `GetAll`:**  
  این متد برای دریافت تمامی ارائه‌دهندگان از پایگاه داده استفاده می‌شود. نتایج به‌صورت `DataTable` بازگردانده می‌شوند.

- **متد `Update`:**  
  این متد برای به‌روزرسانی اطلاعات یک ارائه‌دهنده موجود در پایگاه داده استفاده می‌شود. پارامترهای آن شامل شناسه ارائه‌دهنده (`id`) و شیء `Provider` با اطلاعات جدید است.

- **متد `Delete`:**  
  این متد برای حذف یک ارائه‌دهنده از پایگاه داده استفاده می‌شود. پارامتر آن شناسه ارائه‌دهنده (`id`) است.

- **متد `MapToProvider`:**  
  این متد برای تبدیل یک سطر از `DataRow` به شیء `Provider` استفاده می‌شود.

---

### ۴. **کلاس `BookingService.cs`**

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using Customer_Management_Uni.Models;
using Customer_Management_Uni.Utils;
using System.Data;

namespace Customer_Management_Uni.Services
{
    public class BookingService
    {
        private readonly DatabaseManager _dbManager;

        public BookingService(DatabaseManager dbManager)
        {
            _dbManager = dbManager;
        }

        public void AddBooking(Booking booking)
        {
            string query = @"INSERT INTO bookings (user_id, provider_id, room_id, start_time, end_time)
                             VALUES (@UserID, @ProviderID, @RoomID, @StartTime, @EndTime)";

            var parameters = new Dictionary<string, object>
            {
                { "@UserID", booking.user_id },
                { "@ProviderID", booking.provider_id },
                { "@RoomID", booking.room_id },
                { "@StartTime", booking.start_time },
                { "@EndTime", booking.end_time }
            };

            _dbManager.ExecuteNonQuery(query, parameters);
        }

        public DataTable GetAllBookings()
        {
            string query = "SELECT * FROM bookings";

            var results = _dbManager.ExecuteQuery(query);

            return results;
        }

        public Booking GetBookingById(int bookingId)
        {
            string query = "SELECT * FROM bookings WHERE booking_id = @BookingID  limit 1;";

            var parameters = new Dictionary<string, object>
    {
        { "@BookingID", bookingId }
    };

            var results = _dbManager.ExecuteQuery(query, parameters);

            foreach (DataRow row in results.Rows)
            {
                return MapToBooking(row);
            }

            return null;
        }

        public DataTable GetBookingsByDate(DateTime? startDate = null, DateTime? endDate = null)
        {
            if (!startDate.HasValue)
                startDate = DateTime.MinValue;
            if (!endDate.HasValue)
                endDate = DateTime.MaxValue;

            string query = @"
                    select booking_id as id, start_time as ""Start Time"",
                    end_time as ""End Time"",
                    r.location  || '-'||  r.name as ""Room"" ,
                    p.name as ""Provider"",
                    u.name  as ""Customer""
                    From Bookings b
                    inner join users u on b.user_id  = u.id
                    inner join Rooms r on r.id = b.room_id
                    inner join Providers p on p.id = b.provider_id
                        WHERE (start_time >= @StartDate AND start_time <= @EndDate)
                           OR (end_time >= @StartDate AND end_time <= @EndDate)";

                            var parameters = new Dictionary<string, object>
                    {
                        { "@StartDate", startDate },
                        { "@EndDate", endDate }
                    };

            var result = _dbManager.ExecuteQuery(query, parameters);

            return result;
        }

        public Booking GetBookingByUserName(string userName)
        {
            string query = @"
        SELECT
            bookings.booking_id,
            bookings.user_id,
            bookings.provider_id,
            bookings.room_id,
            bookings.start_time,
            bookings.end_time
        FROM bookings
        INNER JOIN users ON bookings.user_id = users.id
        WHERE users.name = @UserName
        limit 1;";

        var parameters = new Dictionary<string, object>
        {
            { "@UserName", userName }
        };

            var result = _dbManager.ExecuteQuery(query, parameters);

            foreach (DataRow row in result.Rows)
            {
                return MapToBooking(row);
            }

            return null;
        }

        public void UpdateBooking(Booking booking)
        {
            string query = @"UPDATE bookings
                             SET user_id = @UserID, provider_id = @ProviderID, room_id = @RoomID,
                                 start_time = @StartTime, end_time = @EndTime
                             WHERE booking_id = @BookingID";

            var parameters = new Dictionary<string, object>
            {
                { "@BookingID", booking.booking_id },
                { "@UserID", booking.user_id },
                { "@ProviderID", booking.provider_id },
                { "@RoomID", booking.room_id },
                { "@StartTime", booking.start_time },
                { "@EndTime", booking.end_time }
            };

            _dbManager.ExecuteNonQuery(query, parameters);
        }

        public void DeleteBooking(int bookingId)
        {
            string query = "DELETE FROM bookings WHERE booking_id = @BookingID";

            var parameters = new Dictionary<string, object>
            {
                { "@BookingID", bookingId }
            };

            _dbManager.ExecuteNonQuery(query, parameters);
        }

        public bool HasConflict(Booking newBooking)
        {
            string query = @"SELECT * FROM bookings
                     WHERE (room_id = @RoomID OR provider_id = @ProviderID) AND
                           ((@NewStartTime BETWEEN start_time AND end_time) OR
                            (@NewEndTime BETWEEN start_time AND end_time) OR
                            (start_time BETWEEN @NewStartTime AND @NewEndTime) OR
                            (end_time BETWEEN @NewStartTime AND @NewEndTime))
                      limit 1;";

            var parameters = new Dictionary<string, object>
                {
                    { "@RoomID", newBooking.room_id },
                    { "@ProviderID", newBooking.provider_id },
                    { "@NewStartTime", newBooking.start_time },
                    { "@NewEndTime", newBooking.end_time }
                };

            var result = _dbManager.ExecuteQuery(query, parameters);

            foreach (var _ in result.Rows)
            {
                return true;
            }

            return false;
        }

        private Booking MapToBooking(DataRow row)
        {
            return new Booking
            {
                booking_id = Convert.ToInt32(row["booking_id"]),
                user_id = Convert.ToInt32(row["user_id"]),
                provider_id = Convert.ToInt32(row["provider_id"]),
                room_id = Convert.ToInt32(row["room_id"]),
                start_time = Convert.ToDateTime(row["start_time"]),
                end_time = Convert.ToDateTime(row["end_time"])
            };
        }
    }
}
```

### توضیحات:

- **فضای نام (Namespace):**  
  این کلاس در فضای نام `Customer_Management_Uni.Services` قرار دارد.

- **کلاس `BookingService`:**  
  این کلاس برای مدیریت عملیات مربوط به رزروها در سیستم طراحی شده است. این کلاس از `DatabaseManager` برای تعامل با پایگاه داده استفاده می‌کند.

- **متد `AddBooking`:**  
  این متد برای افزودن یک رزرو جدید به پایگاه داده استفاده می‌شود. پارامترهای آن شامل شیء `Booking` است که اطلاعات رزرو را در خود نگه می‌دارد.

- **متد `GetAllBookings`:**  
  این متد برای دریافت تمامی رزروها از پایگاه داده استفاده می‌شود. نتایج به‌صورت `DataTable` بازگردانده می‌شوند.

- **متد `GetBookingById`:**  
  این متد برای دریافت یک رزرو بر اساس شناسه آن استفاده می‌شود. پارامتر آن شناسه رزرو (`bookingId`) است.

- **متد `GetBookingsByDate`:**  
  این متد برای دریافت رزروها در یک بازه زمانی مشخص استفاده می‌شود. پارامترهای آن شامل تاریخ شروع (`startDate`) و تاریخ پایان (`endDate`) هستند.

- **متد `GetBookingByUserName`:**  
  این متد برای دریافت یک رزرو بر اساس نام کاربر استفاده می‌شود. پارامتر آن نام کاربر (`userName`) است.

- **متد `UpdateBooking`:**  
  این متد برای به‌روزرسانی اطلاعات یک رزرو موجود در پایگاه داده استفاده می‌شود. پارامترهای آن شامل شیء `Booking` با اطلاعات جدید است.

- **متد `DeleteBooking`:**  
  این متد برای حذف یک رزرو از پایگاه داده استفاده می‌شود. پارامتر آن شناسه رزرو (`bookingId`) است.

- **متد `HasConflict`:**  
  این متد برای بررسی تداخل زمان‌بندی رزروها استفاده می‌شود. پارامتر آن شیء `Booking` است که اطلاعات رزرو جدید را در خود نگه می‌دارد.

- **متد `MapToBooking`:**  
  این متد برای تبدیل یک سطر از `DataRow` به شیء `Booking` استفاده می‌شود.

---

### **جمع‌بندی**

کلاس‌های `RoomService`, `UserService`, `ProviderService`, و `BookingService` به‌عنوان سرویس‌های اصلی سیستم مدیریت مشتریان دانشگاهی استفاده می‌شوند. این کلاس‌ها امکان مدیریت داده‌های مربوط به اتاق‌ها، کاربران، ارائه‌دهندگان و رزروها را فراهم می‌کنند. هر کلاس از `DatabaseManager` برای تعامل با پایگاه داده استفاده می‌کند و عملیات CRUD (ایجاد، خواندن، به‌روزرسانی، حذف) را پشتیبانی می‌کند.

## فرم ها

### 1.فرم های اتاق ها

1. **کلاس `RoomDataUpsert.cs`**
2. **کلاس `RoomForm.cs`**

---

### ۱. **کلاس `RoomDataUpsert.cs`**

```csharp
using System;
using System.Windows.Forms;

namespace Customer_Management_Uni.Forms
{
    public partial class RoomDataUpsert : Form
    {
        public string Name => NameData.Text;
        public string Location => LocationData.Text;

        public RoomDataUpsert()
        {
            InitializeComponent();
        }

        public void PopulateFields(string name, string location)
        {
            NameData.Text = name;
            LocationData.Text = location;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Location))
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
```

### توضیحات:

- **فضای نام (Namespace):**  
  این کلاس در فضای نام `Customer_Management_Uni.Forms` قرار دارد.

- **کلاس `RoomDataUpsert`:**  
  این کلاس یک فرم ویندوزی است که برای افزودن یا به‌روزرسانی اطلاعات اتاق‌ها استفاده می‌شود. این فرم شامل فیلدهایی برای نام و مکان اتاق است.

- **ویژگی‌ها (Properties):**

  - `Name`: نام اتاق که از فیلد `NameData` دریافت می‌شود.
  - `Location`: مکان اتاق که از فیلد `LocationData` دریافت می‌شود.

- **متد `PopulateFields`:**  
  این متد برای پر کردن فیلدهای فرم با اطلاعات موجود استفاده می‌شود. پارامترهای آن شامل نام (`name`) و مکان (`location`) اتاق هستند.

- **رویداد `CancelButton_Click`:**  
  این رویداد زمانی اتفاق می‌افتد که کاربر دکمه لغو را کلیک کند. فرم بسته شده و نتیجه `DialogResult.Cancel` بازگردانده می‌شود.

- **رویداد `SaveButton_Click`:**  
  این رویداد زمانی اتفاق می‌افتد که کاربر دکمه ذخیره را کلیک کند. اگر فیلدهای نام و مکان خالی باشند، یک پیغام خطا نمایش داده می‌شود. در غیر این صورت، فرم بسته شده و نتیجه `DialogResult.OK` بازگردانده می‌شود.

---

### ۲. **کلاس `RoomForm.cs`**

```csharp
using Customer_Management_Uni.Models;
using Customer_Management_Uni.Services;
using Customer_Management_Uni.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Customer_Management_Uni.Forms
{
    public partial class RoomForm : Form
    {
        private DatabaseManager databaseManager;
        private RoomService RoomHelper;
        public RoomForm()
        {
            InitializeComponent();
            databaseManager = new DatabaseManager();
            RoomHelper = new RoomService(databaseManager);
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {
            LoadActive();
        }

        private void LoadActive()
        {
            try
            {
                DataTable rooms = RoomHelper.GetAll();
                DataView.DataSource = rooms;
                DataView.AutoSize = true;
                DataView.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading rooms: {ex.Message}");
            }
        }

        private void DeleteData_Click(object sender, EventArgs e)
        {
            if (DataView.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected rows?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in DataView.SelectedRows)
                    {
                        int id = Convert.ToInt32(row.Cells["Id"].Value);
                        RoomHelper.Delete(id);
                    }
                    MessageBox.Show("Selected rows deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadActive();
                }
            }
            else
            {
                MessageBox.Show("No rows selected.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RefershForm_Click(object sender, EventArgs e)
        {
            LoadActive();
        }

        private void InsertData_Click(object sender, EventArgs e)
        {
            using (RoomDataUpsert form = new RoomDataUpsert())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    Room newRoom = new Room
                    {
                        Id = 0,
                        Name = form.Name,
                        Location = form.Location
                    };

                    RoomHelper.Add(newRoom);
                    LoadActive();
                }
            }
        }

        private void UpdateData_Click(object sender, EventArgs e)
        {
            if (DataView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DataView.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                string name = selectedRow.Cells["Name"].Value?.ToString();
                string location = selectedRow.Cells["Location"].Value?.ToString();

                using (RoomDataUpsert form = new RoomDataUpsert())
                {
                    form.PopulateFields(name, location);

                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        Room ToUpdateData = new Room
                        {
                            Id = id,
                            Name = form.Name,
                            Location = form.Location
                        };

                        try
                        {
                            RoomHelper.Update(id, ToUpdateData);
                            MessageBox.Show("Data updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadActive();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error updating data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No row selected for update.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
```

### توضیحات:

- **فضای نام (Namespace):**  
  این کلاس در فضای نام `Customer_Management_Uni.Forms` قرار دارد.

- **کلاس `RoomForm`:**  
  این کلاس یک فرم ویندوزی است که برای مدیریت اتاق‌ها در سیستم استفاده می‌شود. این فرم امکان افزودن، به‌روزرسانی، حذف و مشاهده اتاق‌ها را فراهم می‌کند.

- **متد `RoomForm_Load`:**  
  این رویداد زمانی اتفاق می‌افتد که فرم بارگذاری می‌شود. در این رویداد، متد `LoadActive` فراخوانی می‌شود تا لیست اتاق‌ها بارگذاری شود.

- **متد `LoadActive`:**  
  این متد برای بارگذاری تمامی اتاق‌ها از پایگاه داده و نمایش آن‌ها در `DataView` استفاده می‌شود.

- **رویداد `DeleteData_Click`:**  
  این رویداد زمانی اتفاق می‌افتد که کاربر دکمه حذف را کلیک کند. اگر ردیفی انتخاب شده باشد، یک پیغام تأیید نمایش داده می‌شود و در صورت تأیید، ردیف‌های انتخاب شده حذف می‌شوند.

- **رویداد `RefershForm_Click`:**  
  این رویداد زمانی اتفاق می‌افتد که کاربر دکمه بازخوانی را کلیک کند. در این رویداد، لیست اتاق‌ها مجدداً بارگذاری می‌شود.

- **رویداد `InsertData_Click`:**  
  این رویداد زمانی اتفاق می‌افتد که کاربر دکمه افزودن را کلیک کند. فرم `RoomDataUpsert` نمایش داده می‌شود و در صورت تأیید، اطلاعات جدید به پایگاه داده اضافه می‌شود.

- **رویداد `UpdateData_Click`:**  
  این رویداد زمانی اتفاق می‌افتد که کاربر دکمه به‌روزرسانی را کلیک کند. اگر ردیفی انتخاب شده باشد، فرم `RoomDataUpsert` با اطلاعات موجود پر شده و در صورت تأیید، اطلاعات به‌روزرسانی می‌شوند.

---

### **جمع‌بندی**

کلاس‌های `RoomDataUpsert` و `RoomForm` به‌عنوان بخش‌های رابط کاربری سیستم مدیریت مشتریان دانشگاهی استفاده می‌شوند. `RoomDataUpsert` برای افزودن یا به‌روزرسانی اطلاعات اتاق‌ها و `RoomForm` برای مدیریت کامل اتاق‌ها طراحی شده‌اند. این کلاس‌ها از `RoomService` برای تعامل با پایگاه داده استفاده می‌کنند و عملیات CRUD (ایجاد، خواندن، به‌روزرسانی، حذف) را پشتیبانی می‌کنند.

### 2. فرم های اطلاعات اشخاص

1. **کلاس `UserDataUpsert.cs`**
2. **کلاس `UserForm.cs`**

---

### ۱. **کلاس `UserDataUpsert.cs`**

```csharp
using System;
using System.Linq;
using System.Windows.Forms;

namespace Customer_Management_Uni.Forms
{
    public partial class UserDataUpsert : Form
    {
        public string ProviderName => NameData.Text;
        public string Number => NumberData.Text;
        public string EmailAddress => EmailAddressData.Text;

        public UserDataUpsert()
        {
            InitializeComponent();
        }

        public void PopulateFields(string name, string number, string emailAddress)
        {
            NameData.Text = name;
            NumberData.Text = number.ToString();
            EmailAddressData.Text = emailAddress;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ProviderName) || string.IsNullOrEmpty(EmailAddress))
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Number.Any(char.IsLetter))
            {
                MessageBox.Show("Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
```

### توضیحات:

- **فضای نام (Namespace):**  
  این کلاس در فضای نام `Customer_Management_Uni.Forms` قرار دارد.

- **کلاس `UserDataUpsert`:**  
  این کلاس یک فرم ویندوزی است که برای افزودن یا به‌روزرسانی اطلاعات کاربران استفاده می‌شود. این فرم شامل فیلدهایی برای نام، شماره تماس و آدرس ایمیل کاربر است.

- **ویژگی‌ها (Properties):**

  - `ProviderName`: نام کاربر که از فیلد `NameData` دریافت می‌شود.
  - `Number`: شماره تماس کاربر که از فیلد `NumberData` دریافت می‌شود.
  - `EmailAddress`: آدرس ایمیل کاربر که از فیلد `EmailAddressData` دریافت می‌شود.

- **متد `PopulateFields`:**  
  این متد برای پر کردن فیلدهای فرم با اطلاعات موجود استفاده می‌شود. پارامترهای آن شامل نام (`name`)، شماره تماس (`number`) و آدرس ایمیل (`emailAddress`) کاربر هستند.

- **رویداد `CancelButton_Click`:**  
  این رویداد زمانی اتفاق می‌افتد که کاربر دکمه لغو را کلیک کند. فرم بسته شده و نتیجه `DialogResult.Cancel` بازگردانده می‌شود.

- **رویداد `SaveButton_Click`:**  
  این رویداد زمانی اتفاق می‌افتد که کاربر دکمه ذخیره را کلیک کند. اگر فیلدهای نام یا ایمیل خالی باشند، یک پیغام خطا نمایش داده می‌شود. همچنین، اگر شماره تماس شامل حروف باشد، خطای دیگری نمایش داده می‌شود. در غیر این صورت، فرم بسته شده و نتیجه `DialogResult.OK` بازگردانده می‌شود.

---

### ۲. **کلاس `UserForm.cs`**

```csharp
using Customer_Management_Uni.Models;
using Customer_Management_Uni.Services;
using Customer_Management_Uni.Utils;
using System;
using System.Data;
using System.Windows.Forms;

namespace Customer_Management_Uni.Forms
{
    public partial class UserForm : Form
    {
        private DatabaseManager databaseManager;
        private UserService UserHelper;
        public UserForm()
        {
            InitializeComponent();
            databaseManager = new DatabaseManager();
            UserHelper = new UserService(databaseManager);
        }

        private void LoadActive()
        {
            try
            {
                DataTable Users = UserHelper.GetAll();
                DataView.DataSource = Users;
                DataView.AutoSize = true;
                DataView.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading bookings: {ex.Message}");
            }
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            LoadActive();
        }

        private void DeleteData_Click(object sender, EventArgs e)
        {
            if (DataView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in DataView.SelectedRows)
                {
                    int id = Convert.ToInt32(row.Cells["Id"].Value);

                    UserHelper.Delete(id);
                }

                MessageBox.Show("Selected rows deleted successfully!");

                LoadActive();
            }
            else
            {
                MessageBox.Show("No rows selected.");
            }
        }

        private void RefershForm_Click(object sender, EventArgs e)
        {
            LoadActive();
        }

        private void InsertData_Click(object sender, EventArgs e)
        {
            using (UserDataUpsert form = new UserDataUpsert())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    User ToInsertData = new User
                    {
                        Id = 0,
                        Name = form.ProviderName,
                        Number = form.Number,
                        EmailAddress = form.EmailAddress
                    };

                    UserHelper.Add(ToInsertData);
                    LoadActive();
                }
            }
        }

        private void UpdateData_Click(object sender, EventArgs e)
        {
            if (DataView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DataView.SelectedRows[0];

                try
                {
                    int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                    string name = selectedRow.Cells["Name"].Value?.ToString();
                    string number = selectedRow.Cells["Number"].Value.ToString();
                    string email = selectedRow.Cells["email_address"].Value?.ToString();

                    if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email))
                    {
                        MessageBox.Show("Invalid data in the selected row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    using (UserDataUpsert form = new UserDataUpsert())
                    {
                        form.PopulateFields(name, number, email);

                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            User updatedUser = new User
                            {
                                Id = id,
                                Name = form.ProviderName,
                                Number = form.Number,
                                EmailAddress = form.EmailAddress
                            };

                            // Update data in the database
                            UserHelper.Update(id, updatedUser);

                            MessageBox.Show("Data updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Refresh the DataGridView (if needed)
                            LoadActive();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No row selected for update.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
```

### توضیحات:

- **فضای نام (Namespace):**  
  این کلاس در فضای نام `Customer_Management_Uni.Forms` قرار دارد.

- **کلاس `UserForm`:**  
  این کلاس یک فرم ویندوزی است که برای مدیریت کاربران در سیستم استفاده می‌شود. این فرم امکان افزودن، به‌روزرسانی، حذف و مشاهده کاربران را فراهم می‌کند.

- **متد `LoadActive`:**  
  این متد برای بارگذاری تمامی کاربران از پایگاه داده و نمایش آن‌ها در `DataView` استفاده می‌شود.

- **رویداد `UserForm_Load`:**  
  این رویداد زمانی اتفاق می‌افتد که فرم بارگذاری می‌شود. در این رویداد، متد `LoadActive` فراخوانی می‌شود تا لیست کاربران بارگذاری شود.

- **رویداد `DeleteData_Click`:**  
  این رویداد زمانی اتفاق می‌افتد که کاربر دکمه حذف را کلیک کند. اگر ردیفی انتخاب شده باشد، ردیف‌های انتخاب شده حذف می‌شوند.

- **رویداد `RefershForm_Click`:**  
  این رویداد زمانی اتفاق می‌افتد که کاربر دکمه بازخوانی را کلیک کند. در این رویداد، لیست کاربران مجدداً بارگذاری می‌شود.

- **رویداد `InsertData_Click`:**  
  این رویداد زمانی اتفاق می‌افتد که کاربر دکمه افزودن را کلیک کند. فرم `UserDataUpsert` نمایش داده می‌شود و در صورت تأیید، اطلاعات جدید به پایگاه داده اضافه می‌شود.

- **رویداد `UpdateData_Click`:**  
  این رویداد زمانی اتفاق می‌افتد که کاربر دکمه به‌روزرسانی را کلیک کند. اگر ردیفی انتخاب شده باشد، فرم `UserDataUpsert` با اطلاعات موجود پر شده و در صورت تأیید، اطلاعات به‌روزرسانی می‌شوند.

---

### **جمع‌بندی**

کلاس‌های `UserDataUpsert` و `UserForm` به‌عنوان بخش‌های رابط کاربری سیستم مدیریت مشتریان دانشگاهی استفاده می‌شوند. `UserDataUpsert` برای افزودن یا به‌روزرسانی اطلاعات کاربران و `UserForm` برای مدیریت کامل کاربران طراحی شده‌اند. این کلاس‌ها از `UserService` برای تعامل با پایگاه داده استفاده می‌کنند و عملیات CRUD (ایجاد، خواندن، به‌روزرسانی، حذف) را پشتیبانی می‌کنند.

### 3. فرم های اطلاعات تامین کننده گان خدمات

1. **کلاس `ProviderDataUpsert.cs`**
2. **کلاس `ProviderForm.cs`**

---

### ۱. **کلاس `ProviderDataUpsert.cs`**

```csharp
using System;
using System.Linq;
using System.Windows.Forms;

namespace Customer_Management_Uni.Forms
{
    public partial class ProviderDataUpsert : Form
    {
        public string ProviderName => NameData.Text;
        public string ServiceType => ServiceTypeData.Text;
        public string Number => NumberData.Text;
        public string EmailAddress => EmailAddressData.Text;

        public ProviderDataUpsert()
        {
            InitializeComponent();
        }

        public void PopulateFields(string name, string serviceType, string number, string emailAddress)
        {
            NameData.Text = name;
            ServiceTypeData.Text = serviceType;
            NumberData.Text = number;
            EmailAddressData.Text = emailAddress;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ProviderName) || string.IsNullOrEmpty(ServiceType) || string.IsNullOrEmpty(EmailAddress))
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Number.Any(char.IsLetter)){
                MessageBox.Show("Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
```

### توضیحات:

- **فضای نام (Namespace):**  
  این کلاس در فضای نام `Customer_Management_Uni.Forms` قرار دارد.

- **کلاس `ProviderDataUpsert`:**  
  این کلاس یک فرم ویندوزی است که برای افزودن یا به‌روزرسانی اطلاعات ارائه‌دهندگان خدمات استفاده می‌شود. این فرم شامل فیلدهایی برای نام، نوع خدمات، شماره تماس و آدرس ایمیل ارائه‌دهنده است.

- **ویژگی‌ها (Properties):**

  - `ProviderName`: نام ارائه‌دهنده که از فیلد `NameData` دریافت می‌شود.
  - `ServiceType`: نوع خدمات ارائه‌دهنده که از فیلد `ServiceTypeData` دریافت می‌شود.
  - `Number`: شماره تماس ارائه‌دهنده که از فیلد `NumberData` دریافت می‌شود.
  - `EmailAddress`: آدرس ایمیل ارائه‌دهنده که از فیلد `EmailAddressData` دریافت می‌شود.

- **متد `PopulateFields`:**  
  این متد برای پر کردن فیلدهای فرم با اطلاعات موجود استفاده می‌شود. پارامترهای آن شامل نام (`name`)، نوع خدمات (`serviceType`)، شماره تماس (`number`) و آدرس ایمیل (`emailAddress`) ارائه‌دهنده هستند.

- **رویداد `SaveButton_Click`:**  
  این رویداد زمانی اتفاق می‌افتد که کاربر دکمه ذخیره را کلیک کند. اگر فیلدهای نام، نوع خدمات یا ایمیل خالی باشند، یک پیغام خطا نمایش داده می‌شود. همچنین، اگر شماره تماس شامل حروف باشد، خطای دیگری نمایش داده می‌شود. در غیر این صورت، فرم بسته شده و نتیجه `DialogResult.OK` بازگردانده می‌شود.

- **رویداد `CancelButton_Click`:**  
  این رویداد زمانی اتفاق می‌افتد که کاربر دکمه لغو را کلیک کند. فرم بسته شده و نتیجه `DialogResult.Cancel` بازگردانده می‌شود.

---

### ۲. **کلاس `ProviderForm.cs`**

```csharp
using Customer_Management_Uni.Services;
using Customer_Management_Uni.Utils;
using System;
using Customer_Management_Uni.Models;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace Customer_Management_Uni.Forms
{
    public partial class ProviderForm : Form
    {
        private DatabaseManager databaseManager;
        private ProviderService ProviderHelper;
        public ProviderForm()
        {
            InitializeComponent();
            databaseManager = new DatabaseManager();
            ProviderHelper = new ProviderService(databaseManager);
        }
        private void ProviderForm_Load(object sender, EventArgs e)
        {
            LoadActive();
        }

        private void LoadActive()
        {
            try
            {
                DataTable providers = ProviderHelper.GetAll();
                DataView.DataSource = providers;
                DataView.AutoSize = true;
                DataView.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading bookings: {ex.Message}");
            }
        }

        private void DeleteData_Click(object sender, EventArgs e)
        {
            if (DataView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in DataView.SelectedRows)
                {
                    int id = Convert.ToInt32(row.Cells["Id"].Value);

                    ProviderHelper.Delete(id);
                }

                MessageBox.Show("Selected rows deleted successfully!");

                LoadActive();
            }
            else
            {
                MessageBox.Show("No rows selected.");
            }
        }

        private void RefershForm_Click(object sender, EventArgs e)
        {
            LoadActive();
        }

        private void InsertData_Click(object sender, EventArgs e)
        {
            using (ProviderDataUpsert form = new ProviderDataUpsert())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    Provider newProvider = new Provider
                    {
                        Id = 0,
                        Name = form.ProviderName,
                        ServiceType = form.ServiceType,
                        Number = form.Number,
                        EmailAddress = form.EmailAddress
                    };

                    ProviderHelper.Add(newProvider);
                    LoadActive();
                }
            }
        }

        private void UpdateData_Click(object sender, EventArgs e)
        {
            if (DataView.SelectedRows.Count > 0)
            {
                var selectedRow = DataView.SelectedRows[0];

                try
                {
                    int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                    string name = selectedRow.Cells["Name"].Value?.ToString();
                    string serviceType = selectedRow.Cells["service_type"].Value?.ToString();
                    string number = selectedRow.Cells["Number"].Value?.ToString();
                    string email = selectedRow.Cells["email_address"].Value?.ToString();

                    using (ProviderDataUpsert form = new ProviderDataUpsert())
                    {
                        form.PopulateFields(name, serviceType, number, email);

                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            Provider updatedProvider = new Provider
                            {
                                Id = id,
                                Name = form.ProviderName,
                                ServiceType = form.ServiceType,
                                Number = form.Number,
                                EmailAddress = form.EmailAddress
                            };

                            ProviderHelper.Update(id, updatedProvider);

                            MessageBox.Show("Data updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LoadActive();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No row selected for update.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
```

### توضیحات:

- **فضای نام (Namespace):**  
  این کلاس در فضای نام `Customer_Management_Uni.Forms` قرار دارد.

- **کلاس `ProviderForm`:**  
  این کلاس یک فرم ویندوزی است که برای مدیریت ارائه‌دهندگان خدمات در سیستم استفاده می‌شود. این فرم امکان افزودن، به‌روزرسانی، حذف و مشاهده ارائه‌دهندگان را فراهم می‌کند.

- **متد `LoadActive`:**  
  این متد برای بارگذاری تمامی ارائه‌دهندگان از پایگاه داده و نمایش آن‌ها در `DataView` استفاده می‌شود.

- **رویداد `ProviderForm_Load`:**  
  این رویداد زمانی اتفاق می‌افتد که فرم بارگذاری می‌شود. در این رویداد، متد `LoadActive` فراخوانی می‌شود تا لیست ارائه‌دهندگان بارگذاری شود.

- **رویداد `DeleteData_Click`:**  
  این رویداد زمانی اتفاق می‌افتد که کاربر دکمه حذف را کلیک کند. اگر ردیفی انتخاب شده باشد، ردیف‌های انتخاب شده حذف می‌شوند.

- **رویداد `RefershForm_Click`:**  
  این رویداد زمانی اتفاق می‌افتد که کاربر دکمه بازخوانی را کلیک کند. در این رویداد، لیست ارائه‌دهندگان مجدداً بارگذاری می‌شود.

- **رویداد `InsertData_Click`:**  
  این رویداد زمانی اتفاق می‌افتد که کاربر دکمه افزودن را کلیک کند. فرم `ProviderDataUpsert` نمایش داده می‌شود و در صورت تأیید، اطلاعات جدید به پایگاه داده اضافه می‌شود.

- **رویداد `UpdateData_Click`:**  
  این رویداد زمانی اتفاق می‌افتد که کاربر دکمه به‌روزرسانی را کلیک کند. اگر ردیفی انتخاب شده باشد، فرم `ProviderDataUpsert` با اطلاعات موجود پر شده و در صورت تأیید، اطلاعات به‌روزرسانی می‌شوند.

---

### **جمع‌بندی**

کلاس‌های `ProviderDataUpsert` و `ProviderForm` به‌عنوان بخش‌های رابط کاربری سیستم مدیریت مشتریان دانشگاهی استفاده می‌شوند. `ProviderDataUpsert` برای افزودن یا به‌روزرسانی اطلاعات ارائه‌دهندگان و `ProviderForm` برای مدیریت کامل ارائه‌دهندگان طراحی شده‌اند. این کلاس‌ها از `ProviderService` برای تعامل با پایگاه داده استفاده می‌کنند و عملیات CRUD (ایجاد، خواندن، به‌روزرسانی، حذف) را پشتیبانی می‌کنند.

### 4. ورودی اصلی برنامه / فرم های رزرو ها

1. **کلاس `ReservationUpsert.cs`**
2. **کلاس `Main.cs`**

---

### ۱. **کلاس `ReservationUpsert.cs`**

```csharp
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Customer_Management_Uni.Models;
using Customer_Management_Uni.Services;

namespace Customer_Management_Uni.Forms
{
    public partial class ReservationUpsert : Form
    {
        private readonly UserService _userService;
        private readonly ProviderService ProviderHelper;
        private readonly RoomService RoomHelper;

        public int UserId { get; set; }
        public int ProviderId { get; set; }
        public int RoomId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public ReservationUpsert(UserService userService, ProviderService providerService, RoomService roomService)
        {
            InitializeComponent();
            _userService = userService;
            ProviderHelper = providerService;
            RoomHelper = roomService;
        }

        private void ReservationUpsert_Load(object sender, EventArgs e)
        {
            LoadUsers();
            LoadProviders();
            LoadRooms();
            StartTimePicker.Format = DateTimePickerFormat.Custom;
            EndTimePicker.Format = DateTimePickerFormat.Custom;
            StartTimePicker.CustomFormat = "yyyy/MM/dd hh:mm tt";
            EndTimePicker.CustomFormat = "yyyy/MM/dd hh:mm tt";
            StartTimePicker.Value = DateTime.Now;
            EndTimePicker.Value = DateTime.Now.AddDays(7);
        }

        private void LoadUsers()
        {
            var users = _userService.GetAll();
            UserComboBox.DataSource = users;
            UserComboBox.DisplayMember = "Name";
            UserComboBox.ValueMember = "Id";
        }

        private void LoadProviders()
        {
            var providers = ProviderHelper.GetAll();
            ProviderComboBox.DataSource = providers;
            ProviderComboBox.DisplayMember = "Name";
            ProviderComboBox.ValueMember = "Id";
        }

        private void LoadRooms()
        {
            var rooms = RoomHelper.GetAll();
            RoomComboBox.DataSource = rooms;
            RoomComboBox.DisplayMember = "Name";
            RoomComboBox.ValueMember = "Id";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            UserId = Convert.ToInt32(UserComboBox.SelectedValue);
            ProviderId = Convert.ToInt32(ProviderComboBox.SelectedValue);
            RoomId = Convert.ToInt32(RoomComboBox.SelectedValue);
            StartTime = StartTimePicker.Value;
            EndTime = EndTimePicker.Value;

            if (StartTime >= EndTime)
            {
                MessageBox.Show("End time must be after start time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
```

### توضیحات:

- **فضای نام (Namespace):**  
  این کلاس در فضای نام `Customer_Management_Uni.Forms` قرار دارد.

- **کلاس `ReservationUpsert`:**  
  این کلاس یک فرم ویندوزی است که برای افزودن یا به‌روزرسانی رزروها استفاده می‌شود. این فرم شامل فیلدهایی برای انتخاب کاربر، ارائه‌دهنده، اتاق و زمان‌بندی رزرو است.

- **ویژگی‌ها (Properties):**

  - `UserId`: شناسه کاربر انتخاب شده.
  - `ProviderId`: شناسه ارائه‌دهنده انتخاب شده.
  - `RoomId`: شناسه اتاق انتخاب شده.
  - `StartTime`: زمان شروع رزرو.
  - `EndTime`: زمان پایان رزرو.

- **متد `ReservationUpsert_Load`:**  
  این رویداد زمانی اتفاق می‌افتد که فرم بارگذاری می‌شود. در این رویداد، لیست کاربران، ارائه‌دهندگان و اتاق‌ها بارگذاری می‌شود و زمان‌بندی پیش‌فرض برای رزرو تنظیم می‌شود.

- **متد `LoadUsers`:**  
  این متد برای بارگذاری لیست کاربران از پایگاه داده و نمایش آن‌ها در `UserComboBox` استفاده می‌شود.

- **متد `LoadProviders`:**  
  این متد برای بارگذاری لیست ارائه‌دهندگان از پایگاه داده و نمایش آن‌ها در `ProviderComboBox` استفاده می‌شود.

- **متد `LoadRooms`:**  
  این متد برای بارگذاری لیست اتاق‌ها از پایگاه داده و نمایش آن‌ها در `RoomComboBox` استفاده می‌شود.

- **رویداد `SaveButton_Click`:**  
  این رویداد زمانی اتفاق می‌افتد که کاربر دکمه ذخیره را کلیک کند. اطلاعات انتخاب شده از فرم استخراج شده و بررسی می‌شود که زمان پایان بعد از زمان شروع باشد. در صورت صحت اطلاعات، فرم بسته شده و نتیجه `DialogResult.OK` بازگردانده می‌شود.

- **رویداد `CancelButton_Click`:**  
  این رویداد زمانی اتفاق می‌افتد که کاربر دکمه لغو را کلیک کند. فرم بسته شده و نتیجه `DialogResult.Cancel` بازگردانده می‌شود.

---

### ۲. **کلاس `Main.cs`**

```csharp
using System;
using System.Collections.Generic;
using Customer_Management_Uni.Utils;
using Customer_Management_Uni.Models;
using Customer_Management_Uni.Services;
using System.Windows.Forms;
using System.Data;

namespace Customer_Management_Uni.Forms
{
    public partial class Main : Form
    {
        private DatabaseManager databaseManager;
        private BookingService BookingHelper;

        public Main()
        {
            InitializeComponent();
            databaseManager = new DatabaseManager();
            BookingHelper = new BookingService(databaseManager);
        }

        private void AddReservation_Click(object sender, EventArgs e)
        {
            var userService = new UserService(databaseManager);
            var providerService = new ProviderService(databaseManager);
            var roomService = new RoomService(databaseManager);

            using (var form = new ReservationUpsert(userService, providerService, roomService))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var reservation = new Booking
                    {
                        user_id = form.UserId,
                        provider_id = form.ProviderId,
                        room_id = form.RoomId,
                        start_time = form.StartTime,
                        end_time = form.EndTime
                    };

                    if (BookingHelper.HasConflict(reservation))
                    {
                        MessageBox.Show("Conflict detected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        BookingHelper.AddBooking(reservation);
                        LoadActiveReserves();
                    }
                }
            }
        }

        private void UpdateReservation_Click(object sender, EventArgs e)
        {
            if (ActiveReservesView.SelectedRows.Count > 0)
            {
                var selectedRow = ActiveReservesView.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["id"].Value);

                var userService = new UserService(databaseManager);
                var providerService = new ProviderService(databaseManager);
                var roomService = new RoomService(databaseManager);

                Booking booking = BookingHelper.GetBookingById(id);
                using (var form = new ReservationUpsert(userService, providerService, roomService))
                {
                    form.UserId = booking.user_id;
                    form.ProviderId = booking.provider_id;
                    form.RoomId = booking.room_id;
                    form.StartTime = booking.start_time;
                    form.EndTime = booking.end_time;

                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        var reservation = new Booking
                        {
                            user_id = form.UserId,
                            provider_id = form.ProviderId,
                            room_id = form.RoomId,
                            start_time = form.StartTime,
                            end_time = form.EndTime
                        };

                        if (BookingHelper.HasConflict(reservation))
                        {
                            MessageBox.Show("Conflict detected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            BookingHelper.UpdateBooking(reservation);
                            LoadActiveReserves();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No reservation selected.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DeleteReservation_Click(object sender, EventArgs e)
        {
            if (ActiveReservesView.SelectedRows.Count > 0)
            {
                var selectedRow = ActiveReservesView.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                BookingHelper.DeleteBooking(id);
                LoadActiveReserves();
            }
            else
            {
                MessageBox.Show("No reservation selected.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoadActiveReserves();
        }

        private void LoadActiveReserves()
        {
            try
            {
                DateTime now = DateTime.Now;
                DataTable bookings = BookingHelper.GetBookingsByDate(now);
                ActiveReservesView.DataSource = bookings;
                ActiveReservesView.AutoSize = true;
                ActiveReservesView.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading bookings: {ex.Message}");
            }
        }

        private void providersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProviderForm form = new ProviderForm();
            form.ShowDialog();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserForm form = new UserForm();
            form.ShowDialog();
        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoomForm form = new RoomForm();
            form.ShowDialog();
        }
    }
}
```

### توضیحات:

- **فضای نام (Namespace):**  
  این کلاس در فضای نام `Customer_Management_Uni.Forms` قرار دارد.

- **کلاس `Main`:**  
  این کلاس فرم اصلی سیستم مدیریت مشتریان دانشگاهی است. این فرم امکان مدیریت رزروها و دسترسی به فرم‌های دیگر (مانند مدیریت کاربران، ارائه‌دهندگان و اتاق‌ها) را فراهم می‌کند.

- **رویداد `AddReservation_Click`:**  
  این رویداد زمانی اتفاق می‌افتد که کاربر دکمه افزودن رزرو را کلیک کند. فرم `ReservationUpsert` نمایش داده می‌شود و در صورت تأیید، رزرو جدید به پایگاه داده اضافه می‌شود.

- **رویداد `UpdateReservation_Click`:**  
  این رویداد زمانی اتفاق می‌افتد که کاربر دکمه به‌روزرسانی رزرو را کلیک کند. اگر ردیفی انتخاب شده باشد، فرم `ReservationUpsert` با اطلاعات موجود پر شده و در صورت تأیید، اطلاعات به‌روزرسانی می‌شوند.

- **رویداد `DeleteReservation_Click`:**  
  این رویداد زمانی اتفاق می‌افتد که کاربر دکمه حذف رزرو را کلیک کند. اگر ردیفی انتخاب شده باشد، رزرو مربوطه از پایگاه داده حذف می‌شود.

- **رویداد `Main_Load`:**  
  این رویداد زمانی اتفاق می‌افتد که فرم اصلی بارگذاری می‌شود. در این رویداد، لیست رزروهای فعال بارگذاری می‌شود.

- **متد `LoadActiveReserves`:**  
  این متد برای بارگذاری رزروهای فعال از پایگاه داده و نمایش آن‌ها در `ActiveReservesView` استفاده می‌شود.

- **رویداد `providersToolStripMenuItem_Click`:**  
  این رویداد زمانی اتفاق می‌افتد که کاربر منوی "ارائه‌دهندگان" را انتخاب کند. فرم `ProviderForm` نمایش داده می‌شود.

- **رویداد `usersToolStripMenuItem_Click`:**  
  این رویداد زمانی اتفاق می‌افتد که کاربر منوی "کاربران" را انتخاب کند. فرم `UserForm` نمایش داده می‌شود.

- **رویداد `roomsToolStripMenuItem_Click`:**  
  این رویداد زمانی اتفاق می‌افتد که کاربر منوی "اتاق‌ها" را انتخاب کند. فرم `RoomForm` نمایش داده می‌شود.

---

### **جمع‌بندی**

کلاس‌های `ReservationUpsert` و `Main` به‌عنوان بخش‌های اصلی رابط کاربری سیستم مدیریت مشتریان دانشگاهی استفاده می‌شوند. `ReservationUpsert` برای افزودن یا به‌روزرسانی رزروها و `Main` برای مدیریت کامل رزروها و دسترسی به سایر فرم‌ها طراحی شده‌اند. این کلاس‌ها از `BookingService` برای تعامل با پایگاه داده استفاده می‌کنند و عملیات CRUD (ایجاد، خواندن، به‌روزرسانی، حذف) را پشتیبانی می‌کنند.
