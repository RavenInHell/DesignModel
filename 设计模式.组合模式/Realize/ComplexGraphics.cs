using System;
using System.Collections.Generic;
using System.Text;
using 设计模式.组合模式.Abstract;

namespace 设计模式.组合模式.Realize
{
    public class ComplexGraphics : Graphics
    {
        private List<Graphics> complexGraphicsList=new List<Graphics>();

        public ComplexGraphics(string name)
            : base(name)
        {

        }
        public  void Add(Graphics g)
        {
            complexGraphicsList.Add(g);
        }

        public override void Draw()
        {
            foreach (Graphics graphicse in complexGraphicsList)
            {
                graphicse.Draw();
            }
        }

        public  void Remove(Graphics g)
        {
            complexGraphicsList.Remove(g);
        }
    }
}
