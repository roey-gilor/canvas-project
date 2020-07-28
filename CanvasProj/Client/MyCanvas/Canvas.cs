using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCanvas
{
    public class Canvas
    {
        public const int maxWidth = 800;
        public const int maxHeight = 600;
        private static int buttonIndex = 0;
        private static int maxButtons = 3;
        private static MyButton[] buttons = new MyButton[maxButtons];
        public static bool CreateNewButton(int x1, int x2, int y1, int y2)
        {
            if (buttonIndex < maxButtons)
            {
                Point p1 = new Point(x1, y1);
                Point p2 = new Point(x2, y2);
                MyButton button = new MyButton(p1, p2);
                buttons[buttonIndex] = button;
                buttonIndex++;
                return true;
            }
            return false;
        }
        public static bool MoveButton(int buttonNumber, int x, int y)
        {
            bool allowedButtonRight = buttons[buttonNumber].SetButtomRight(new Point(x, y));
            bool allowedTopLeft = buttons[buttonNumber].SetTopLeft(new Point(x, y));
            return allowedButtonRight && allowedTopLeft;
        }
        public static bool DeleteLastButton()
        {
            if (buttonIndex == 0)
                return false;
            buttonIndex--;
            return true;
        }
        public static void ClearAllButtons()
        {
            bool isNotEmpety = true;
            while (isNotEmpety)
                isNotEmpety = DeleteLastButton();
        }
        public static int GetCurrentNumberOfButtons() => buttonIndex;
        public static int GetMaxNumberOfButtons() => maxButtons;
        public static int GetTheMaxWidhOfButton()
        {
            int maxWidth = -1;
            if (buttonIndex == 0)
                return 0;
            for (int i = 0; i < buttonIndex; i++)
            {
                if (buttons[i].Width > maxWidth)
                    maxWidth = buttons[i].Width;
            }
            return maxWidth;
        }
        public static int GetTheMaxHeightOfButton()
        {
            int maxHeight = -1;
            if (buttonIndex == 0)
                return 0;
            for (int i = 0; i < buttonIndex; i++)
            {
                if (buttons[i].Height > maxHeight)
                    maxHeight = buttons[i].Height;
            }
            return maxHeight;
        }
        public static bool IsPointInsideAButton(int x, int y)
        {
            bool check = true;
            for (int i = 0; i < buttonIndex; i++)
            {
                check = (buttons[i].ButtomRight.X >= x && buttons[i].TopLeft.X <= x) &&
                    (buttons[i].ButtomRight.Y <= y && buttons[i].TopLeft.Y >= y);
            }
            return check;
        }
        public static bool CheckIfAnyButtonIsOverLapping()
        {
            if (buttonIndex < 2)
                return false;
            int[] sizes = new int[buttonIndex];
            for (int i = 0; i < buttonIndex; i++)
            {
                sizes[i] = buttons[i].Height * buttons[i].Width;
            }
            if (buttonIndex == 2)
                return sizes[0] == sizes[1];
            return sizes[0] == sizes[1] || sizes[0] == sizes[2] || sizes[1] == sizes[2];
        }
        public override string ToString()
        {
            string st = "";
            for (int i = 0; i < buttonIndex; i++)
            {
                st += buttons[i].ToString() + " ";
            }
            return st;
        }
    }
}
