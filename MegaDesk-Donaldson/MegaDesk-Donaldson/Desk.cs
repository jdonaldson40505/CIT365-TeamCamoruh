using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Donaldson
{
    public class Desk
    {

        private const int MIN_WIDTH = 24;
        private const int MAX_WIDTH = 96;
        private const int MIN_HEIGHT = 30;
        private const int MIN_DEPTH = 12;
        private const int MAX_DEPTH = 48;
        private const int MIN_NUM_DRAWERS = 0;
        private const int MAX_DRAWERS = 7;

        private float width;
        private float height;
        private float depth;
        private int drawers;
        
        private String material;

        
        public Desk() { }

        // probably don't need builder pattern because of the need of getters and setter with serialbility perhaps we come back and clean this up later?
        public Desk setWidth(float width)
        {
            this.width = width;
            return this;
        }

        public Desk setHeight(float height)
        {
            this.height = height;
            return this;
        }

        public Desk setDepth(float depth)
        {
            this.depth = depth;
            return this;
        }

        public Desk setDrawers(int drawers)
        {
            this.drawers = drawers;
            return this;
        }

        public Desk setMaterial(String material)
        {
            this.material = material;
            return this;
        }

        public int getTotalMaterials()
        {
            return (int)((this.width * this.height) + (2*(this.height*this.depth)) + (this.depth * this.width));
        }

        public int NumDrawers
        {
            get { return this.drawers; }
            set { this.drawers = value; }
        }

        public String Material
        {
            get { return this.material; }
            set { this.material = value; }
        }

        public float Height
        {
            get { return height; }
            set { height = value; } 
        }

        public float Width
        {
            get { return width; }
            set { width = value; }
        }

        public float Depth
        {
            get { return this.depth; }
            set { this.depth = value; }
        }
    }
}
