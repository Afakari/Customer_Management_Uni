# دستورات شرطی

## مقدمه

- **دستورات کنترلی**: برای اجرای دستورات تحت شرایط خاص استفاده می‌شوند.
- **انواع دستورات کنترلی در C#**:
  - `if`, `else if`, `switch`, `for`, `foreach`, `while`, `do`.

## دستور شرطی `if`

- **ساختار**:
  ```csharp
  if (شرط) {
      // دستورات اگر شرط درست باشد
  } else {
      // دستورات اگر شرط نادرست باشد
  }
  ```
- **نکات**:
  - اگر تعداد دستورات یک خط باشد، می‌توان از `{}` صرف‌نظر کرد.
  - `else` اختیاری است.

## مثال: محاسبه مالیات و حقوق خالص

- **شرط**: اگر حقوق کمتر از 10 میلیون باشد، 10% مالیات، در غیر این صورت 5% مالیات.
  ```csharp
  if (salary < 10000000) {
      tax = salary * 0.10;
  } else {
      tax = salary * 0.05;
  }
  netSalary = salary - tax;
  ```

## دستور شرطی `if` تودرتو

- **ساختار**:
  ```csharp
  if (شرط1) {
      // دستورات اگر شرط1 درست باشد
  } else if (شرط2) {
      // دستورات اگر شرط2 درست باشد
  } else {
      // دستورات اگر هیچ شرطی درست نباشد
  }
  ```
- **نکته**: آخرین `else` اختیاری است.

## کادر پیام (`MessageBox`)

- **استفاده**: برای نمایش اطلاعات یا دریافت پاسخ از کاربر.
- **متد `Show`**:
  ```csharp
  MessageBox.Show("متن پیام", "عنوان", MessageBoxButtons.OK, MessageBoxIcon.Information);
  ```
- **پارامترها**:
  - **پارامتر اول**: متن پیام (اجباری).
  - **پارامتر دوم**: عنوان کادر پیام.
  - **پارامتر سوم**: دکمه‌های نمایش داده‌شده (مانند `OK`, `YesNo`).
  - **پارامتر چهارم**: آیکون (مانند `Error`, `Information`).

## مثال: ورود کاربر با نام کاربری و رمز عبور

- **شرط**: اگر نام کاربری و رمز عبور صحیح نباشند، کاربر حداکثر 3 بار می‌تواند تلاش کند.
  ```csharp
  int attempts = 0;
  while (attempts < 3) {
      if (username == "منصور" && password == "1224") {
          MessageBox.Show("ورود موفق");
          break;
      } else {
          attempts++;
          MessageBox.Show("اطلاعات اشتباه");
      }
  }
  if (attempts == 3) {
      MessageBox.Show("برنامه بسته می‌شود");
  }
  ```

## افزودن فرم جدید به پروژه

- **مراحل**:
  1. در Solution Explorer، راست‌کلیک روی پروژه.
  2. انتخاب `Add` > `Windows Form`.
  3. نام‌گذاری فرم جدید و کلیک `Add`.

## کنترل‌های نگهدارنده (`Containers`)

- **انواع**:
  - `GroupBox`: گروه‌بندی کنترل‌ها با عنوان.
  - `Panel`: گروه‌بندی کنترل‌ها بدون عنوان.
  - `TabControl`: ایجاد صفحات جداگانه.
  - `TableLayoutPanel`: گروه‌بندی کنترل‌ها به صورت جدولی.

## کنترل‌های `CheckBox` و `RadioButton`

- **`CheckBox`**: برای انتخاب گزینه‌های چندگانه.
  - **ویژگی `Checked`**: `true` یا `false`.
- **`RadioButton`**: برای انتخاب یک گزینه از چند گزینه.
  - **ویژگی `Checked`**: `true` یا `false`.

## دستور شرطی `switch`

- **ساختار**:
  ```csharp
  switch (متغیر) {
      case مقدار1:
          // دستورات
          break;
      case مقدار2:
          // دستورات
          break;
      default:
          // دستورات اگر هیچ‌کدام از مقادیر مطابقت نداشته باشد
          break;
  }
  ```
- **نکات**:
  - مقادیر `case` باید منحصر به فرد باشند.
  - `default` اختیاری است.

## مثال: نمایش نام روزهای هفته با استفاده از `switch`

- **شرط**: اگر عدد بین 1 تا 7 باشد، نام روز مربوطه نمایش داده شود، در غیر این صورت پیام خطا.
  ```csharp
  int day = Convert.ToInt32(textBox1.Text);
  switch (day) {
      case 1:
          MessageBox.Show("شنبه");
          break;
      case 2:
          MessageBox.Show("یکشنبه");
          break;
      // سایر روزها
      default:
          MessageBox.Show("عدد خارج از محدوده");
          break;
  }
  ```

حتماً! در اینجا پاسخ‌های کامل به سوالات آورده شده است:

---

### ۱. **دستورات شرطی `if` و `else` در C# چگونه کار می‌کنند؟**

- **پاسخ**:  
  دستور `if` برای اجرای یک بلوک کد در صورتی که شرط داده‌شده درست (`true`) باشد استفاده می‌شود. اگر شرط نادرست (`false`) باشد، بلوک کد داخل `if` اجرا نمی‌شود و در صورت وجود `else`، بلوک کد داخل `else` اجرا می‌شود.  
  مثال:
  ```csharp
  if (age > 18) {
      Console.WriteLine("بزرگسال");
  } else {
      Console.WriteLine("نوجوان");
  }
  ```

---

### ۲. **چگونه می‌توان از دستور `if` تودرتو برای بررسی چند شرط استفاده کرد؟**

- **پاسخ**:  
  با استفاده از `else if` می‌توان چند شرط را به صورت تودرتو بررسی کرد. اگر شرط اول درست نباشد، شرط دوم بررسی می‌شود و به همین ترتیب ادامه می‌یابد.  
  مثال:
  ```csharp
  if (score >= 90) {
      Console.WriteLine("نمره A");
  } else if (score >= 80) {
      Console.WriteLine("نمره B");
  } else if (score >= 70) {
      Console.WriteLine("نمره C");
  } else {
      Console.WriteLine("نمره D");
  }
  ```

---

### ۳. **کادر پیام (`MessageBox`) در C# چه کاربردی دارد و چگونه استفاده می‌شود؟**

- **پاسخ**:  
  `MessageBox` برای نمایش پیام‌ها یا دریافت پاسخ از کاربر استفاده می‌شود. با استفاده از متد `Show` می‌توان پیام، عنوان، دکمه‌ها و آیکون را تنظیم کرد.  
  مثال:
  ```csharp
  MessageBox.Show("آیا مطمئن هستید؟", "تأیید", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
  ```

---

### ۴. **چگونه می‌توان یک برنامه ساده برای محاسبه مالیات و حقوق خالص نوشت؟**

- **پاسخ**:  
  با استفاده از دستور `if` می‌توان مالیات را بر اساس حقوق محاسبه کرد.  
  مثال:
  ```csharp
  double salary = 12000000;
  double tax;
  if (salary < 10000000) {
      tax = salary * 0.10;
  } else {
      tax = salary * 0.05;
  }
  double netSalary = salary - tax;
  Console.WriteLine("حقوق خالص: " + netSalary);
  ```

---

### ۵. **کنترل‌های نگهدارنده (`Containers`) در C# چه کاربردی دارند و انواع آن‌ها چیست؟**

- **پاسخ**:  
  کنترل‌های نگهدارنده برای گروه‌بندی و سازماندهی کنترل‌ها استفاده می‌شوند. انواع آن‌ها شامل `GroupBox`, `Panel`, `TabControl`, و `TableLayoutPanel` هستند.  
  مثال:
  - `GroupBox`: برای گروه‌بندی کنترل‌ها با عنوان.
  - `Panel`: برای گروه‌بندی کنترل‌ها بدون عنوان.

---

### ۶. **تفاوت بین کنترل‌های `CheckBox` و `RadioButton` در C# چیست؟**

- **پاسخ**:
  - `CheckBox`: برای انتخاب چند گزینه از چند گزینه استفاده می‌شود.
  - `RadioButton`: برای انتخاب یک گزینه از چند گزینه استفاده می‌شود.  
    مثال:
  - `CheckBox`: انتخاب علاقه‌مندی‌ها (مثلاً ورزش، موسیقی).
  - `RadioButton`: انتخاب جنسیت (مثلاً مرد، زن).

---

### ۷. **دستور شرطی `switch` در C# چگونه کار می‌کند و چه مزایایی دارد؟**

- **پاسخ**:  
  `switch` برای بررسی مقادیر مختلف یک متغیر استفاده می‌شود. اگر مقدار متغیر با یکی از `case`ها مطابقت داشته باشد، بلوک کد مربوطه اجرا می‌شود.  
  مثال:
  ```csharp
  int day = 3;
  switch (day) {
      case 1:
          Console.WriteLine("شنبه");
          break;
      case 2:
          Console.WriteLine("یکشنبه");
          break;
      default:
          Console.WriteLine("روز نامعتبر");
          break;
  }
  ```

---

### ۸. **چگونه می‌توان یک برنامه ساده برای نمایش نام روزهای هفته با استفاده از `switch` نوشت؟**

- **پاسخ**:  
  با استفاده از `switch` می‌توان عددی بین 1 تا 7 را به نام روزهای هفته تبدیل کرد.  
  مثال:
  ```csharp
  int day = Convert.ToInt32(textBox1.Text);
  switch (day) {
      case 1:
          MessageBox.Show("شنبه");
          break;
      case 2:
          MessageBox.Show("یکشنبه");
          break;
      // سایر روزها
      default:
          MessageBox.Show("عدد خارج از محدوده");
          break;
  }
  ```

---

### ۹. **چگونه می‌توان یک فرم جدید به پروژه در Visual Studio اضافه کرد؟**

- **پاسخ**:
  1. در Solution Explorer، راست‌کلیک روی پروژه.
  2. انتخاب `Add` > `Windows Form`.
  3. نام‌گذاری فرم جدید و کلیک `Add`.

---

### ۱۰. **ویژگی `Checked` در کنترل‌های `CheckBox` و `RadioButton` چه کاربردی دارد؟**

- **پاسخ**:  
  ویژگی `Checked` نشان‌دهنده وضعیت انتخاب کنترل است. اگر `true` باشد، کنترل انتخاب شده است و اگر `false` باشد، انتخاب نشده است.  
  مثال:
  ```csharp
  if (checkBox1.Checked) {
      Console.WriteLine("CheckBox انتخاب شده است");
  }
  ```

---

### ۱۱. **چگونه می‌توان از کادر پیام برای دریافت پاسخ از کاربر استفاده کرد؟**

- **پاسخ**:  
  با استفاده از `MessageBox.Show` و تنظیم دکمه‌ها می‌توان پاسخ کاربر را دریافت کرد.  
  مثال:
  ```csharp
  DialogResult result = MessageBox.Show("آیا مطمئن هستید؟", "تأیید", MessageBoxButtons.YesNo);
  if (result == DialogResult.Yes) {
      Console.WriteLine("کاربر Yes را انتخاب کرد");
  }
  ```

---

### ۱۲. **چگونه می‌توان یک برنامه ساده برای ورود کاربر با نام کاربری و رمز عبور نوشت؟**

- **پاسخ**:  
  با استفاده از `if` می‌توان نام کاربری و رمز عبور را بررسی کرد.  
  مثال:
  ```csharp
  string username = "admin";
  string password = "1234";
  if (username == textBox1.Text && password == textBox2.Text) {
      MessageBox.Show("ورود موفق");
  } else {
      MessageBox.Show("نام کاربری یا رمز عبور اشتباه است");
  }
  ```

---

### ۱۳. **چگونه می‌توان از کنترل `GroupBox` برای گروه‌بندی کنترل‌ها استفاده کرد؟**

- **پاسخ**:  
  با قرار دادن کنترل‌ها داخل `GroupBox` می‌توان آن‌ها را گروه‌بندی کرد.  
  مثال:
  ```csharp
  groupBox1.Controls.Add(radioButton1);
  groupBox1.Controls.Add(radioButton2);
  ```

---

### ۱۴. **چگونه می‌توان از دستور `switch` برای بررسی مقادیر مختلف یک متغیر استفاده کرد؟**

- **پاسخ**:  
  با استفاده از `switch` می‌توان مقادیر مختلف یک متغیر را بررسی کرد.  
  مثال:
  ```csharp
  int number = 2;
  switch (number) {
      case 1:
          Console.WriteLine("یک");
          break;
      case 2:
          Console.WriteLine("دو");
          break;
      default:
          Console.WriteLine("عدد نامعتبر");
          break;
  }
  ```

---

### ۱۵. **چگونه می‌توان یک برنامه ساده برای تغییر رنگ متن و زمینه با استفاده از کنترل‌های `CheckBox` و `RadioButton` نوشت؟**

- **پاسخ**:  
  با استفاده از رویداد `CheckedChanged` می‌توان رنگ متن و زمینه را تغییر داد.  
  مثال:
  ```csharp
  private void checkBox1_CheckedChanged(object sender, EventArgs e) {
      if (checkBox1.Checked) {
          textBox1.BackColor = Color.Red;
      } else {
          textBox1.BackColor = Color.White;
      }
  }
  ```
