using System;
using System.Collections.Generic;

namespace WidgetProductProject {
    class Program {
        static void Main(string[] args) {

            // read in inputs to program - these will be the counts sold of each widget

            // represent items company sells as Widgets - each will have an identifier and a cost

            // for each widget we sell, multiply its cost by the number sold

            // return the total

            // program inputs
            Input ironS = new Input(2, 0);
            Input goldS = new Input(2, 1);
            Input diamondS = new Input(2, 2);
            Input basicP = new Input(2, 3);
            Input ultraP = new Input(2, 4);
            Input supremeP = new Input(2, 5);

            var Inputs = new List<Input> { ironS, goldS, diamondS, basicP, ultraP, supremeP };

            Widget ironService = new Widget(5, 0);
            Widget goldService = new Widget(6, 1);
            Widget diamondService = new Widget(9, 2);
            Widget basicProduct = new Widget(3, 3);
            Widget ultraProduct = new Widget(50, 4);
            Widget supremeProduct = new Widget(500, 5);

            int totalSold = 0;
            var Widgets = new List<Widget> {ironService, goldService, diamondService, basicProduct, ultraProduct, supremeProduct };
            foreach(Widget currentWidget in Widgets) {
                totalSold = totalSold + Inputs[currentWidget.Id].count * currentWidget.cost;
            }
            Console.WriteLine("total sold was: " + totalSold);
        }
    }

    class Widget {
        public int cost { get; set; }
        public int Id { get; set; }

        public Widget(int _cost, int _Id) {
            this.cost = _cost;
            this.Id = _Id;
        }
    }

    class Input {
        public int count { get; set; }
        public int Id { get; set; }

        public Input(int _count, int _Id) {
            this.count = _count;
            this.Id = _Id;
        }
    }
}
