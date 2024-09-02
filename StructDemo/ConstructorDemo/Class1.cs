using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConstructorDemo
{
    public int Id;
    public string Name;
    public double Price;
    public int Stock;

    public override string ToString()
    {
        return $"{Id} {Name} {Price} {Stock}";
    }
    public Product(int id, string name, double price, int stuck)
    {
        d=id
    public Product(int id, string name, double price)
    {
        this.id = id;
        this.name = name;
        this.price = price;
        this.stock = 0;
    }
}

