# WEB452_ASP.NET_0835715_Assignments
# Date:2023-10-04
# Time:0603

Started the Project with the fresh mind set bring back the memories from the C# assignment nowlets start the assignment firstly we will see the requiermenets and the assignment details. it say we have to create the MVC application with some functionalities and Some added pages.

So we will start our project with the Creating the MVC application on the With our Product name Which :"Tie" And Named the file:- "Aditya_Tie"

So the Application is created and we will Firstly changing the Welcome message to the Product Tie 

And i also become Familiar with the whole interface and becoming familar with all files taking my time tounderstand all files and examining the files and after this we will start the Parts that was provided by the Andrew in the content folder for us. As far as i understaand the Project there is the basicly we have to create the database table as we created in the class afterwards there are few changes that we will do according to requierement. 

Time 0932
## Part 2 Adding Controller 
Started the Part 2 As the part one Was just creating the MVC application 
So, in the second part of my project, I added something pretty important - a controller called `HelloWorldController.cs`. I basically followed the step-by-step instructions from the website to make this happen. It wasn't too hard, and the best part is, it worked!

After I did what the website said, I got the same output as the picture they showed. It was a pretty cool feeling to see my project working just as I wanted it to. So, Part 2 is done and dusted!

I'm excited to see what's next, but Part 3 is going to be about the `Movie.cs` file, which might be a bit trickier. Stay tuned for more updates!

Lets take a little break and we will start with the part 3
Time : 1223
## Part 3: Adding a View

Alright, here we are in Part 3, and things are getting interesting. Today, I added a new file called `Index.cshtml` in the `View/HelloWorld` folder. It's a crucial part of giving my project a user interface.

I followed the instructions to create this `Index.cshtml` file, and I even tested it - it's working like a charm. It's always a relief when things go smoothly in coding, right?

But that's not all! I also made some changes to the `Views/Shared/_Layout.cshtml` file. I added our company name, "Fashion Tie," to the title. It's as simple as tweaking the title tag, and now my project looks more professional with our company's name up there.

Time : 1508

Inside the `Index.cshtml`, I changed the title to "FashionTie" and added a heading that says "Tie List." Everything looks just perfect, and the output is spot on. It's always satisfying to see your changes take effect.

So, in Part 3, I've not only added a view but also made my project look more polished and branded with our company's name. It's shaping up nicely, and I can't wait to see what's next!

Finally its Just a Start of the Assignment i am feeling like its too much mannn 
no problem we will go one step at time one goal at time which is completeing all the part sucessfully without any error 
now we will go to the Part 4 which i think is the Movie.cs File thing that i am scared of lets see what happens.......

So i thought i will dothe assignment in one day but i dont think so its gonna happpen 1-2 days its right now 
Time : 2209
And i am Tierd of the all day we will cuntionue this work tommorow thank you peace out

Date : 2023-10-05
Time 1234

## Part 4 Add a Model Class 

See this the one now we will Add Movie.cs Means We will Add the Tie.Cs file in the Model Folder and we will create the Characterstics according to the tie Product minimum should be 6 its done we add id , product name , material and its avaviable or not just likethis in the Public class Tie.

We Will perfome now the NUGET package From PMC Console Posted the Code
#### Install-Package Microsoft.EntityFrameworkCore.SqlServer With Vesrion 3.1.12

Now Similar We Will create a NEw File name in The Data Folder Which e=we WIll Create From the Scratch Abnd replace the Code Carefull withmy names and Namspacenot the movie and i definetliy think this movie and tie will create an error in my application, but i hope it should not create this kind of error 
now 
using Aditya_Tie.Data;
using Microsoft.EntityFrameworkCore;
Add this think 
After thus configuered the databasse 
 
     options.UseSqlServer(Configuration.GetConnectionString("TieContext")));

Time: 0456
Scaffold pages

Add Controller dialog:

Model class: Tie (Aditya_Tie.Models)
Data context class: TieContext (Aditya_Tie.Data)

Followed the steps and got the error , it says  the

                   build failed try it again 

its now 0819 pass

and still figuring out the error
i think there is somestep missing from my side or  the tere is a syntax error or i think there might me channce in the changing name from movie to tie i messed up some were......

its 1023
and finally found the error. There was multiple things i change firstly i checked my code in the Tie.cs and TieContext.cs. Then, there was also a extra curly bracket in there...and maybe something more but I just looked at the code carefully and comparing with it the movie code.

So now we got our controller which is TieControlller.cs and there is also Razor view files for Create, Delete, Details, Edit, and Index pages (*Views/Movies/`.cshtml`)

Now we will take rest and come back next day
Date : 2023-10-06
Time 0914

I am in college and now we will start where we left of so next step is migration 

           Add-Migration InitialCreate
           Update-Database

Run the Above two code in My PMC ran flawlessly, which surprised me, but it is all good and we will not ruin it Lollll.

Tested the application running and it showing the  blank table with my field names thats good and now we will not check it because i know if i put the create new in there then i have to 

     SqlException: Cannot open database "TieContext-1" requested by the login. The login failed.
           
 By the way i got this error because i didnt know that pmc runs i commanad at aone time so i was trying to work quickly and i tried to run both command Add database one and update database one togthere and it ran only first one so i learned my lesson not to do work quick. slow and steady wins the race in class adrew taught us loolllll.

 time : 0345
 
Each and every thing is looking good and everything is were it should be 

## Part 5 Working with sql
 
Check the table designer and table data there is each and every field and there is not a data in it obivousuly we didnt add the data.

Now we will create SeedData.cs in the Model Folder 

its just similar code to the the Movie Seeddata file but here we will add our own space names and filed to it and we need to add 10 entries in it, which I will create at  time 

time : 0912

Similar now we will update the Our Program.cs 

which was not easy for me i have to write manually each and every line its good practice but still it was not loving 

I tested the Application everything is on point this time i was preety much confident.

## Part 6 REquiered field should be proper 

NOTE : GRABAGE IN GRABAGE OUT 

so we have to specify what should be go inside each field so that we can not get the database 

      using System.ComponentModel.DataAnnotations;
       using System.ComponentModel.DataAnnotations.Schema;
For my price : [Column(TypeName = "decimal(18, 2)")]
For my Release Data :         [Display(Name = "Release Date")]
                              [DataType(DataType.Date)]


Recalling the Index by this :

                      app.UseEndpoints(endpoints =>
            {
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
        });

time : 1208

its late now so we do rest late 

Byeeee
Date : 2023-10-07
Time 1041
## Part 7 add search to an ASP.NET Core MVC app

        public async Task<IActionResult> Index(string tieMaterial, string searchString)
        {
            // Use LINQ to get list of tie materials.
            IQueryable<string> materialQuery = from t in _context.Tie
                                               orderby t.Material
                                               select t.Material;

            var ties = from t in _context.Tie
                       select t;

            if (!string.IsNullOrEmpty(searchString))
            {
                ties = ties.Where(s => s.Design.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(tieMaterial))
            {
                ties = ties.Where(x => x.Material == tieMaterial);
            }

            var tieMaterialVM = new TieMaterialViewModel
            {
                Materials = new SelectList(await materialQuery.Distinct().ToListAsync()),
                Ties = await ties.ToListAsync()
            };

            return View(tieMaterialVM);
        }


this was my code after i did all my editing and changing and everyhting you can say this the final code to add search string 

Views/Ties/Index.cshtml

Added the code 

     <form asp-controller="Movies" asp-action="Index">
         <p>
             Title: <input type="text" name="SearchString" />
             <input type="submit" value="Filter" />
         </p>
     </form>

for html 

## TieMaterialViewModel.cs 


MY TieMaterialViewModel.cs 

    using Microsoft.AspNetCore.Mvc.Rendering;
    using System.Collections.Generic;
    
    namespace Aditya_Tie.Models
    {
        public class TieMaterialViewModel
        {
            public List<Tie> Ties { get; set; }  // Represents a list of ties
            public SelectList Materials { get; set; }  // Represents a list of materials for ties
            public string SelectedMaterial { get; set; }  // Represents the selected material
            public string SearchString { get; set; }  // Represents a search string for filtering ties
        }
    }

also updated the index.cshtml to make the
to add the cshtml file to get 

     <select asp-for="TieMaterial" asp-items="Model.Material">
            <option value="">All</option>
        </select>

        Title: <input type="text" asp-for="SearchString" />

working ammzingly


Time 1407

## Part 8, add a new field to an ASP.NET Core MVC app

Which is unique part as we have to add the rating witht the custome rating with 1-5 as poor to excellent 

my updated Tie.cs 

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Design { get; set; } // Design or style of the tie

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; } // Date when the tie was released or manufactured

        [Required]
        [StringLength(30)]
        public string Material { get; set; } // Material of the tie (e.g., Silk, Polyester)

        [Required]
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; } // Price of the tie

        public bool IsAvailable { get; set; } // Indicates whether the tie is currently available in stock

        [Required]
        public CustomRatingScale Rating { get; set; }
    }

    public enum CustomRatingScale
    {
        [Display(Name = "Poor")]
        One = 1,

        [Display(Name = "Fair")]
        Two = 2,

        [Display(Name = "Good")]
        Three = 3,

        [Display(Name = "Very Good")]
        Four = 4,

        [Display(Name = "Excellent")]
        Five = 5
    }
    }


 and 

 and adding the Bind Property value in the create and edit.cshtml file with rating 

 also editing the index file as shown in the website

      <th>
            @Html.DisplayNameFor(model => model.Tie[0].Rating)
        </th>

Update the /Views/Ties/Create.cshtml with a Rating field

Also Updated the Seed data here is the one example :

         Id = 1,
         Design = "Classic Striped",
         ReleaseDate = DateTime.Parse("2023-10-05"),
         Material = "Silk",
         Price = 29.99M,
         IsAvailable = true,
         Rating = CustomRatingScale.Three
         
Time : 2343

Updated the

               Add-Migration Rating
               Update-Database

Date : 2023-10-09
time : 0732

its been two days since i have seen the code 

checked my pervious codes and tested the application agin its working greatly 

now we will add the vadilation step 

## Part 9 Validation step 

add the nessearcy validation points in the fields here is my code looking now 

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Design { get; set; } // Design or style of the tie

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; } // Date when the tie was released or manufactured

        [Required]
        [StringLength(30)]
        public string Material { get; set; } // Material of the tie (e.g., Silk, Polyester)

        [Required]
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; } // Price of the tie

        public bool IsAvailable { get; set; } // Indicates whether the tie is currently available in stock

        [Required]
        public CustomRatingScale Rating { get; set; }

Now everything is done in  the link and works good and amazingly 
Its time is 1221

Now we wil do the about us we will create an new file for in the Home/AboutUS.cshtml

Added the nessearcy contains for the according to the requierement 
now we will add the CSS style in the aboutus file and i got the idea to add the these css file in my index.cshtml and in my tie folder with the all Create...Details and all file so that my table will also get the css and also added the fonts in the css and we did the navigation link to the table in the index file so that sir can go from home to table by clicking on the link and on the home page we added the image by creatin g the new folder in wwwroot and name the folder img and added four image from the internet and linked them and added the 
in the index.cshtml 
DATE: 2023-10-10
time : 1209
Now i have to publish the application in the azure AND MY STIDENT AZURE ACCOUNT IS EXPIERDED I emailed the sir about the situation atleast see what happens.

Date : 2023-10-11

Got the meesage from the sir i have re-take the azure student a count did it 
now we will publish 

     Link : https://adityatie20231010173153new.azurewebsites.net/
Date : 2023-10-11
publish is done 
but the table is not working we will try to figure out this thing.....


Date : 2023-10-12
time0231
still trying to figure out the database table but i dont think its gonna work so we will call it the assignment because today we have to submit the assignment so i will call it done from my side i have did each and everything possible from side on alteast see how much marks we get fingers crossed 

Thank you so much sir for the assignmment had and fun and little problem but loved it.



 
