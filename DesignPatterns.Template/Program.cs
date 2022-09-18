using DesignPatterns.Template;

Shopping shopping1 = new Television();
shopping1.TemplateMethod();

Console.WriteLine("*************************");

Shopping shopping2 = new Fridge();
shopping2.TemplateMethod();