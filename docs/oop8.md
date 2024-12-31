### جزوه آموزشی برنامه‌نویسی شیءگرا با C#

**منبع:** Beginning C# Object-Oriented Programming  
**نویسنده:** Dan Clark  
**مدرس:** شكار

### **فصل ۱: سربارگذاری متدها (Method Overloading)**

#### **۱.۱ تعریف سربارگذاری**

- **سربارگذاری:** امکان تعریف چند متد با نام یکسان اما با پارامترهای ورودی متفاوت.
- **مثال:**

```csharp
public void Display(int a)
{
    Console.WriteLine(a);
}

public void Display(string b)
{
    Console.WriteLine(b);
}
```

#### **۱.۲ استفاده از سربارگذاری**

- **مثال:**

```csharp
Display(10); // فراخوانی متد اول
Display("Hello"); // فراخوانی متد دوم
```

### **فصل ۲: مدیریت خطا با `Try-Catch`**

#### **۲.۱ ساختار `Try-Catch`**

- **ساختار:**

```csharp
try
{
    // کدی که ممکن است خطا دهد
}
catch (Exception ex)
{
    // مدیریت خطا
}
finally
{
    // کدی که همیشه اجرا می‌شود
}
```

#### **۲.۲ مثال:**

```csharp
try
{
    int a = 10 / 0; // خطای تقسیم بر صفر
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("خطای تقسیم بر صفر رخ داد.");
}
finally
{
    Console.WriteLine("این بخش همیشه اجرا می‌شود.");
}
```

### **فصل ۳: کپسوله‌سازی (Encapsulation)**

#### **۳.۱ سطوح دسترسی (Access Modifiers)**

- **`public`:** قابل دسترسی از هر جای برنامه.
- **`private`:** فقط داخل کلاس قابل دسترسی.
- **`protected`:** داخل کلاس و زیرکلاس‌ها قابل دسترسی.
- **`internal`:** داخل فضای نام (Namespace) قابل دسترسی.

#### **۳.۲ مثال:**

```csharp
public class Person
{
    private string name; // فقط داخل کلاس قابل دسترسی
    public int Age; // از هر جای برنامه قابل دسترسی
}
```

### **فصل ۴: نوار منو (MenuStrip)**

#### **۴.۱ ایجاد نوار منو**

- **مراحل:**
  1. افزودن کنترل `MenuStrip` به فرم.
  2. اضافه کردن آیتم‌های منو مانند `File`, `Edit` و غیره.

#### **۴.۲ مثال:**

```csharp
private void Form1_Load(object sender, EventArgs e)
{
    ToolStripMenuItem fileMenu = new ToolStripMenuItem("File");
    menuStrip1.Items.Add(fileMenu);
}

---


```

### **سوالات و جواب‌ها**

#### **سوال ۱:** سربارگذاری متدها چیست؟

**جواب:** امکان تعریف چند متد با نام یکسان اما با پارامترهای ورودی متفاوت.

#### **سوال ۲:** چگونه می‌توان خطاها را در C# مدیریت کرد؟

**جواب:** با استفاده از بلوک‌های `Try-Catch`.

#### **سوال ۳:** تفاوت بین `public` و `private` چیست؟

**جواب:** `public` از هر جای برنامه قابل دسترسی است، اما `private` فقط داخل کلاس قابل دسترسی است.

#### **سوال ۴:** چگونه می‌توان یک نوار منو در فرم ایجاد کرد؟

**جواب:** با استفاده از کنترل `MenuStrip` و اضافه کردن آیتم‌های منو.
