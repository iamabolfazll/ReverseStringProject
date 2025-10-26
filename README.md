# 🌀 سامانه معکوس‌کننده رشته‌ها (Reverse String System)

یک وب‌اپلیکیشن ساده و جذاب ساخته‌شده با **ASP.NET Core MVC**  
که به‌صورت هوشمند، رشته‌ی متنی واردشده را **معکوس** می‌کند  
و حتی تشخیص می‌دهد آیا آن رشته **پالیندروم (Palindrome)** است یا خیر!

---

## ✨ ویژگی‌ها

- 🔁 معکوس‌سازی دقیق رشته‌ها به هر زبان (فارسی، انگلیسی و ترکیبی)  
- 🧠 تشخیص خودکار پالیندروم بودن رشته  
- ⚡ پردازش سریع و بدون نیاز به ذخیره‌سازی داده  
- 💬 طراحی کاربرپسند با Bootstrap 5  
- 🛡️ بدون نیاز به JavaScript یا CSS سفارشی  
- 🌐 کاملاً ریسپانسیو و سازگار با موبایل  

---

## 📸 پیش‌نمایش رابط کاربری

| صفحه اصلی | نتیجه معکوس‌سازی |
|-------------|----------------|
| فرم ورودی رشته | نمایش رشته‌ی اصلی و معکوس به‌صورت کارت‌های زیبا |

(در این قسمت می‌تونی بعداً تصویر اسکرین‌شات صفحه رو اضافه کنی  
مثلاً با دستور زیر:  
`![screenshot](docs/screenshot.png)`)

---

## 🧩 ساختار پروژه




ReverseStringProject/
│
├── Controllers/
│ └── HomeController.cs # کنترلر اصلی شامل منطق معکوس‌سازی
│
├── Views/
│ └── Home/
│ ├── Index.cshtml # صفحه اصلی و فرم کاربر
│ └── _ViewImports.cshtml
│
├── wwwroot/
│ ├── lib/ # فایل‌های Bootstrap و آیکون‌ها
│ └── (بدون نیاز به CSS اختصاصی)
│
├── Models/
│ └── StringModel.cs (در صورت نیاز به مدل داده‌ای)
│
└── Program.cs / Startup.cs # تنظیمات ASP.NET Core



---

## ⚙️ نحوه اجرا

1. سورس پروژه را کلون کن:

   ```bash
   git clone https://github.com/YourUsername/ReverseStringProject.git
# 2. وارد پوشه پروژه شو
cd ReverseStringProject

# 3. اجرای پروژه با دات‌نت
dotnet run

# 4. باز کردن مرورگر و رفتن به آدرس
#    توجه: پورت ممکنه بسته به تنظیمات تغییر کنه
https://localhost:5001




مثال / Example   :

ورودی / Input:

گرگ


خروجی / Output:

گرگ


🟡 این رشته یک پالیندروم است ✅
🟡 This string is a Palindrome ✅




🧑‍💻 توسعه‌دهنده / Developer

توسعه‌یافته توسط Abolfazl Mohammadi
Built with ❤️ using ASP.NET Core MVC + Bootstrap 5
