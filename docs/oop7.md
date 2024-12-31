### جزوه آموزشی برنامه‌نویسی شیءگرا با C#

**منبع:** Beginning C# Object-Oriented Programming  
**نویسنده:** Dan Clark  
**مدرس:** شكار

### **فصل ۱: کلاس‌ها و اشیا**

#### **۱.۱ تعریف کلاس**

- **کلاس:** یک قالب برای ایجاد اشیا است که شامل فیلدها، متدها و رویدادها می‌شود.
- **ساختار:**

```csharp
public class ClassName
{
    // فیلدها
    public int Field1;
    private string Field2;

    // متدها
    public void Method1()
    {
        // دستورات
    }
}
```

- **مثال:**

```csharp
public class Person
{
    public string Name;
    public int Age;
}
```

#### **۱.۲ ایجاد شی از کلاس**

- **ساختار:**

```csharp
ClassName objectName = new ClassName();
```

- **مثال:**

```csharp
Person person1 = new Person();
person1.Name = "Ali";
person1.Age = 25;
```

#### **۱.۳ ارث‌بری (Inheritance)**

- **کاربرد:** برای ایجاد کلاس‌های جدید از کلاس‌های موجود.
- **ساختار:**

```csharp
public class DerivedClass : BaseClass
{
    // فیلدها و متدهای جدید
}
```

- **مثال:**

```csharp
public class Student : Person
{
    public string Major;
}
```

### **فصل ۲: انتقال داده بین فرم‌ها**

#### **۲.۱ انتقال داده با استفاده از آرگومان‌ها**

- **مثال:**

```csharp
// فرم اول
Form2 form2 = new Form2(textBox1.Text, textBox2.Text);
form2.Show();

// فرم دوم
public Form2(string name, string family)
{
    InitializeComponent();
    label1.Text = name;
    label2.Text = family;
}
```

#### **۲.۲ انتقال داده با استفاده از کلاس‌ها**

- **مثال:**

```csharp
// کلاس مشترک
public class SharedData
{
    public static string Data1;
    public static string Data2;
}

// فرم اول
SharedData.Data1 = textBox1.Text;
SharedData.Data2 = textBox2.Text;
Form2 form2 = new Form2();
form2.Show();

// فرم دوم
label1.Text = SharedData.Data1;
label2.Text = SharedData.Data2;
```

### **فصل ۳: اتصال به پایگاه داده**

#### **۳.۱ اتصال به پایگاه داده**

- **ساختار:**

```csharp
SqlConnection con = new SqlConnection("ConnectionString");
con.Open();
```

- **مثال:**

```csharp
SqlConnection con = new SqlConnection("Data Source=DESKTOP-TGQ708P;Initial Catalog=form;Integrated Security=True");
con.Open();
```

#### **۳.۲ اجرای کوئری‌ها**

- **درج داده:**

```csharp
SqlCommand cmd = new SqlCommand("INSERT INTO TableName (Column1, Column2) VALUES (@Value1, @Value2)", con);
cmd.Parameters.AddWithValue("@Value1", value1);
cmd.Parameters.AddWithValue("@Value2", value2);
cmd.ExecuteNonQuery();
```

- **نمایش داده:**

```csharp
SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM TableName", con);
DataTable dt = new DataTable();
ad.Fill(dt);
dataGridView1.DataSource = dt;
```

---

### **سوالات و جواب‌ها**

#### **سوال ۱:** چگونه یک کلاس در C# تعریف می‌شود؟

**جواب:** با استفاده از کلمه کلیدی `class` و تعریف فیلدها و متدها در داخل آن.

```csharp
public class Person
{
    public string Name;
    public int Age;
}
```

#### **سوال ۲:** چگونه می‌توان یک شی از کلاس ایجاد کرد؟

**جواب:** با استفاده از کلمه کلیدی `new`.

```csharp
Person person1 = new Person();
```

#### **سوال ۳:** ارث‌بری در C# چگونه کار می‌کند؟

**جواب:** با استفاده از علامت `:` و نام کلاس پایه.

```csharp
public class Student : Person
{
    public string Major;
}
```

#### **سوال ۴:** چگونه می‌توان داده‌ها را بین فرم‌ها انتقال داد؟

**جواب:** با استفاده از آرگومان‌ها یا کلاس‌های مشترک.

```csharp
// فرم اول
Form2 form2 = new Form2(textBox1.Text, textBox2.Text);
form2.Show();

// فرم دوم
public Form2(string name, string family)
{
    InitializeComponent();
    label1.Text = name;
    label2.Text = family;
}
```

#### **سوال ۵:** چگونه می‌توان به پایگاه داده متصل شد؟

**جواب:** با استفاده از کلاس `SqlConnection` و رشته اتصال.

```csharp
SqlConnection con = new SqlConnection("Data Source=DESKTOP-TGQ708P;Initial Catalog=form;Integrated Security=True");
con.Open();
```
