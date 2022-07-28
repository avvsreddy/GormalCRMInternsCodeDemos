/*
 * Design and Program the classes based on the following requirements

An IDE supports different types of Programming Languages like C#, C and Java. All the programming languages have the following methods used by the IDE to support adding elements:
1. getUnit() which returns a string
2. getParadigm() which returns a string
3. getName() which returns a string
The getUnit() methods returns the string "Class" or "Function" depending on whether the language is Object Oriented or Procedural.
The getParadigm() methods returns the string "ObjectOriented" or "Procedural" depending on whether the language is Object Oriented or Procedural.
The getName() method returns the name of the language. These methods are used to design the support for the languages in an IDE.

Note: Avoid code duplication

 */

IDE ide = new IDE();
LangCSharp cs = new LangCSharp();
LangJava java = new LangJava();
LangC c = new LangC();
LangPython p = new LangPython();

ide.Languages.Add(cs);
ide.Languages.Add(java);
ide.Languages.Add(c);
ide.Languages.Add(p);

ide.WorkWithLanguages();




class IDE
{
    //public LangCSharp CSharp { get; set; }
    //public LangJava Java { get; set; }
    //public LangC C { get; set; }

    public List<ILanguage> Languages { get; set; } = new List<ILanguage>();

    public void WorkWithLanguages()
    {

        foreach (ILanguage lang in Languages)
        {
            Console.WriteLine(lang.GetName());
            Console.WriteLine(lang.GetUnit());
            Console.WriteLine(lang.GetParadigm());
        }
        //Console.WriteLine(Java.GetName());
        //Console.WriteLine(Java.GetUnit());
        //Console.WriteLine(Java.GetParadigm());

        //Console.WriteLine(C.GetName());
        //Console.WriteLine(C.GetUnit());
        //Console.WriteLine(C.GetParadigm());
    }
}

interface ILanguage
{
    string GetName();
    string GetUnit();
    string GetParadigm();
}


abstract class OOLang : ILanguage
{
    public string GetUnit()
    {
        return "Class";
    }
    public string GetParadigm()
    {
        return "Object Oriented";
    }

    abstract public string GetName();
    
}

abstract class ProcLang : ILanguage
{
    public string GetUnit()
    {
        return "Function";
    }
    public string GetParadigm()
    {
        return "Procedure Oriented";
    }

    abstract public string GetName();
    
}

class LangCSharp : OOLang
{
    override public string GetName()
    {
        return "CSharp";
    }
   
}

class LangJava : OOLang
{
    override public string GetName()
    {
        return "Java";
    }
    
}

class LangC : ProcLang
{
    override public string GetName()
    {
        return "C Language";
    }
    
}



class LangPython : OOLang
{
    public override string GetName()
    {
        return "Python";
    }
}