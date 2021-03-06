﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using DesignModel.VistorPattern.Element;

namespace DesignModel.VistorPattern
{
    /// <summary>
    /// 对象结构
    /// </summary>
    public class ObjectStructure
    {
        private ArrayList elements = new ArrayList();

        public ArrayList Elements
        {
            get { return elements; }
        }

        public ObjectStructure()
        {
            Random ran=new Random();

            for (int i = 0; i < 6; i++)
            {
                int ranNum = ran.Next(10);
                if (ranNum>5)
                {
                    elements.Add(new ElementA());

                }
                else
                {
                    elements.Add(new ElementB());
                }
            }
        }
    }
}
