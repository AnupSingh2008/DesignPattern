using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.DisignPattern.CreationalPattern
{
    public class Pages
    {

    }

    class Skill : Pages
    {

    }
    class Education: Pages
    {

    }
    class Experience : Pages
    {

    }
    class Introduction : Pages
    {

    }
    class Result : Pages
    {

    }
    class Conclusion : Pages
    {

    }
    class Summary : Pages
    {

    }
    class Bibliography : Pages
    {

    }

    abstract class Document
    {
        private List<Pages> _pages = new List<Pages>();

        public Document()
        {
            this.CreatePages();
        }
        protected abstract void CreatePages();

        public List<Pages> Pages
        {
            get { return _pages; }
        }
    }
   
    class Resume : Document
    {
        protected override void CreatePages()
        {
            Pages.Add(new Skill());
            Pages.Add(new Education());
            Pages.Add(new Experience());
        }

    }

    class Report : Document
    {
        protected override void CreatePages()
        {
            Pages.Add(new Introduction());
            Pages.Add(new Result());
            Pages.Add(new Conclusion());
            Pages.Add(new Summary());
            Pages.Add(new Bibliography());
        }
    }

}
