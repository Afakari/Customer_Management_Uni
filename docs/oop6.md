### جزوه آموزشی برنامه‌نویسی شیءگرا با C#

**منبع:** Beginning C# Object-Oriented Programming  
**نویسنده:** Dan Clark  
**مدرس:** شکاری

### **فصل ۱: آرایه‌ها**

#### **۱.۱ آرایه یک بعدی**

آرایه‌ها برای ذخیره چند داده هم‌نوع تحت یک نام استفاده می‌شوند.

- **تعریف آرایه:**

```csharp
int[] x = new int[5]; // آرایه ای با ۵ عنصر از نوع int
```

- **اندیس‌دهی:** اندیس آرایه از صفر شروع می‌شود.

```csharp
x[0] = 10; // مقداردهی به اولین عنصر
```

- **مقداردهی اولیه:** اگر مقداردهی نشود، مقادیر پیش‌فرض اعمال می‌شوند:
  - `int`: ۰
  - `bool`: false
  - `string`: null

```csharp
string[] names = new string[] {"Ali", "Reza", "Hossein"};
```

#### **۱.۲ دستیابی به عناصر آرایه**

برای دسترسی به عناصر آرایه از اندیس استفاده می‌شود:

```csharp
int[] numbers = {10, 20, 30};
int secondNumber = numbers[1]; // 20
```

#### **۱.۳ یافتن تعداد عناصر آرایه**

با استفاده از خاصیت `Length`:

```csharp
int count = numbers.Length; // 3
```

#### **۱.۴ آرایه دو بعدی (ماتریس)**

آرایه‌ای با دو اندیس (سطر و ستون).

- **تعریف:**

```csharp
int[,] matrix = new int[3, 3]; // ماتریس ۳x۳
```

- **مقداردهی:**

```csharp
int[,] matrix = { {1, 2, 3}, {4, 5, 6}, {7, 8, 9} };
```

- **دستیابی به عناصر:**

```csharp
int element = matrix[1, 2]; // 6
```

#### **۱.۵ آرایه دندانه‌ای (Jagged Array)**

آرایه‌ای که هر عنصر آن خود یک آرایه است.

- **تعریف:**

```csharp
int[][] jaggedArray = new int[3][];
jaggedArray[0] = new int[5]; // اولین عنصر یک آرایه با ۵ عنصر
```

### **فصل ۲: حلقه‌ها و پیمایش آرایه‌ها**

#### **۲.۱ حلقه `foreach`**

برای پیمایش آرایه‌ها و مجموعه‌ها:

```csharp
int[] numbers = {1, 2, 3, 4, 5};
foreach (int num in numbers)
{
    Console.WriteLine(num);
}
```

### **فصل ۳: متدهای کلاس `Array`**

#### **۳.۱ مرتب‌سازی (`Sort`)**

برای مرتب‌سازی آرایه:

```csharp
Array.Sort(numbers); // اعداد را به ترتیب صعودی مرتب می‌کند
```

#### **۳.۲ معکوس کردن (`Reverse`)**

برای معکوس کردن ترتیب عناصر:

```csharp
Array.Reverse(numbers);
```

#### **۳.۳ جستجوی دودویی (`BinarySearch`)**

برای جستجوی سریع در آرایه‌های مرتب‌شده:

```csharp
int index = Array.BinarySearch(numbers, 3); // اندیس عدد ۳ را برمی‌گرداند
```

### **فصل ۴: ساختمان (Structure)**

#### **۴.۱ تعریف ساختمان**

ساختمان‌ها برای ذخیره داده‌های غیرهم‌نوع استفاده می‌شوند.

```csharp
public struct Student
{
    public int Id;
    public string Name;
    public double Grade;
}
```

#### **۴.۲ استفاده از ساختمان**

```csharp
Student student1;
student1.Id = 1;
student1.Name = "Ali";
student1.Grade = 18.5;
```

### **فصل ۵: Dictionary**

#### **۵.۱ تعریف و استفاده**

برای ذخیره جفت‌های کلید-مقدار:

```csharp
Dictionary<string, string> phoneBook = new Dictionary<string, string>();
phoneBook.Add("Ali", "09123456789");
string aliNumber = phoneBook["Ali"]; // 09123456789
```

### **فصل ۶: انتقال اطلاعات بین فرم‌ها**

#### **۶.۱ استفاده از آرگومان‌ها**

برای انتقال داده‌ها بین فرم‌ها:

```csharp
// فرم اول
int number = Convert.ToInt32(textBox1.Text);
Form2 form2 = new Form2(number);
form2.Show();

// فرم دوم
public Form2(int num)
{
    InitializeComponent();
    int doubledNumber = num * 2;
    textBox1.Text = doubledNumber.ToString();
}
```

---

### **تمرین‌ها و مثال‌ها**

#### **تمرین ۱:**

برنامه‌ای بنویسید که نام و شماره تلفن ۱۰ نفر را در آرایه‌ای ذخیره کند و سپس با دریافت نام، شماره تلفن مربوطه را نمایش دهد.

#### **تمرین ۲:**

برنامه‌ای بنویسید که نمرات دانشجویان را در یک آرایه دندانه‌ای ذخیره کرده و معدل هر دانشجو را محاسبه و نمایش دهد.

#### **تمرین ۳:**

برنامه‌ای بنویسید که اطلاعات دانشجو (شماره دانشجویی، نام، نمرات) را در یک ساختمان ذخیره کرده و معدل او را محاسبه کند.
