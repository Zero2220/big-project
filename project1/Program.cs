using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] mehsulNames = { "kitab","qelem","karandas","derslik"};

            string  number;
            do
            {

                bool checkNameBool;
                Console.WriteLine("-------------Menu------------");
                Console.WriteLine("1. Butun mehsullara bax");
                Console.WriteLine("2. Sechilmish mehsula bax (index deyerine gore)");
                Console.WriteLine("3. Yeni mehsul elave et");
                Console.WriteLine("4. Mehsul adini deyish");
                Console.WriteLine("5. Sechilmish mehsulu  sil (id deyerine gore)");
                Console.WriteLine("0. Emeliyyati bitir");


                number = Console.ReadLine();

                switch (number)
                {

                    case "1":

                        Console.WriteLine("Butun mehsullar:");
                        showAllNames(mehsulNames);

                        break;

                    case "2":

                        Console.WriteLine("Sechilmish mehsula bax:");
                        int selected = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(mehsulNames[selected]);


                        break;
                    case "3":

                        Console.WriteLine("--------Yeni mehsul elave et--------");
                        Console.WriteLine("daxil etmek istediyiniz mehsulu yazin:");
                        string newElement;
                        do
                        {
                            checkNameBool = false;
                            newElement = Console.ReadLine();
                            checkNameBool =checkName(ref mehsulNames, checkNameBool, newElement);
                        }
                        while (2 > newElement.Length || 20 < newElement.Length || checkNameBool ==true);
                        addElement(ref mehsulNames, newElement);
                        showAllNames(mehsulNames);
                        break;
                    case "4":

                        Console.WriteLine("----------mehsul adini deyish----------");
                        showAllNames(mehsulNames);
                        Console.WriteLine("isdediyiniz mehsulun indeksini daxil edin:");
                        int elementIndex = Convert.ToInt32(Console.ReadLine()); 
                        changeName(ref mehsulNames,elementIndex);
                        break; 

                    case "5":

                        Console.WriteLine("----------Sechilmish mehsulu sil----------");
                        showAllNames(mehsulNames);
                        Console.WriteLine("silmek isdediyiniz mehsulun indeksini sechin:");
                        int deletedElementId = Convert.ToInt32(Console.ReadLine());
                        deleteName(ref mehsulNames,deletedElementId);
                        
                        break;

                    case "0":

                        Console.WriteLine("----------Emeliyyati bitir----------");
                        Console.WriteLine("emeliyyat bitdi");
                        break;

                    default:

                        Console.WriteLine("----------yanliş emeliyyat----------");
                        
                        break;
                



                
                
                }
            }
            while (number != "0");


        }
        static void addElement(ref string[] mehsulNames,string newElement)
        {
            
            
                string[] names1 = new string[mehsulNames.Length + 1];
                int startIndex = 0;
                int endIndex = 0;
                string correctElement = "";

                for (int i = 0; i < names1.Length - 1; i++)
                {

                    names1[i] = mehsulNames[i];


                }
                for (int i = 0; i < newElement.Length; i++)
                {


                    if (newElement[i] != ' ')
                    {
                        startIndex = i;
                        break;

                    }


                }
                for (int i = newElement.Length - 1; i >= 0; i--)
                {

                    if (newElement[i] != ' ')
                    {

                        endIndex = i;
                        break;
                    }


                }

                for (int i = startIndex; i <= endIndex; i++)
                {

                    correctElement += newElement[i];

                }
                names1[names1.Length - 1] = correctElement;
                mehsulNames = names1;





        }
        static void showAllNames(string[] names)
        {

            for(int i = 0;i < names.Length;i++)
            {

                Console.WriteLine($"{i}.{names[i]}");




            }

        }
        static void changeName(ref string[] mehsulNames,int elementIndex)
        {

            for(int i = 0;i<=mehsulNames.Length;i++)
            {

                if (elementIndex == i)
                {
                    do
                    {

                        mehsulNames[i] = Console.ReadLine();

                    }
                    while (2 > mehsulNames[i].Length || mehsulNames[i].Length>20);
                    

                }
                


            }


        }
        static void deleteName(ref string[] mehsulNames,int deletedElementId)
        {                                                       

            string[] newArray = new string[mehsulNames.Length];

            if (mehsulNames.Length>deletedElementId && deletedElementId>=0)
            {


                for(int i = 0; i < newArray.Length; i++)
            {

                    if (i == deletedElementId)
                    {
                        newArray[i] = "";


                    }
                    else
                    {

                        newArray[i]=mehsulNames[i];
                    }


                }
                mehsulNames = newArray;

            }
            else
            {

                Console.WriteLine("yanlish reqem");




            }
            

            



        }
        static bool checkName(ref string[] mehsulNames,bool checkNameBool,string newElement)
        {
            for (int i = 0;i<mehsulNames.Length;i++)
            {
                if (newElement == mehsulNames[i])
                {

                    checkNameBool = true;


                }

            }
            return checkNameBool;
        }
    }
}
