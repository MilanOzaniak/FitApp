using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitApp.Views;
using MvvmHelpers.Commands;
using Xamarin.Forms;

namespace FitApp.ViewModels
{
    public class MealsViewModel : ContentPage
    {
        //  Weightgain
        public AsyncCommand Wg1Command { get; set; }
        public AsyncCommand Wg2Command { get; set; }
        public AsyncCommand Wg3Command { get; set; }
        public AsyncCommand Wg4Command { get; set; }
        public AsyncCommand Wg5Command { get; set; }
        public AsyncCommand Wg6Command { get; set; }

        //  Breakfast
        public AsyncCommand Br1Command { get; set; }
        public AsyncCommand Br2Command { get; set; }
        public AsyncCommand Br3Command { get; set; }
        public AsyncCommand Br4Command { get; set; }
        public AsyncCommand Br5Command { get; set; }
        public AsyncCommand Br6Command { get; set; }

        //  Vegan
        public AsyncCommand Vegan1Command { get; set; }
        public AsyncCommand Vegan2Command { get; set; }
        public AsyncCommand Vegan3Command { get; set; }
        public AsyncCommand Vegan4Command { get; set; }
        public AsyncCommand Vegan5Command { get; set; }
        public AsyncCommand Vegan6Command { get; set; }

        //  WeightLoss
        public AsyncCommand Wl1Command { get; set; }
        public AsyncCommand Wl2Command { get; set; }
        public AsyncCommand Wl3Command { get; set; }
        public AsyncCommand Wl4Command { get; set; }
        public AsyncCommand Wl5Command { get; set; }
        public AsyncCommand Wl6Command { get; set; }

        public MealsViewModel()
        {
            Wg1Command = new AsyncCommand(Wg1);
            Wg2Command = new AsyncCommand(Wg2);
            Wg3Command = new AsyncCommand(Wg3);
            Wg4Command = new AsyncCommand(Wg4);
            Wg5Command = new AsyncCommand(Wg5);
            Wg6Command = new AsyncCommand(Wg6);

            Br1Command = new AsyncCommand(Br1);
            Br2Command = new AsyncCommand(Br2);
            Br3Command = new AsyncCommand(Br3);
            Br4Command = new AsyncCommand(Br4);
            Br5Command = new AsyncCommand(Br5);
            Br6Command = new AsyncCommand(Br6);

            Vegan1Command = new AsyncCommand(Vegan1);
            Vegan2Command = new AsyncCommand(Vegan2);
            Vegan3Command = new AsyncCommand(Vegan3);
            Vegan4Command = new AsyncCommand(Vegan4);
            Vegan5Command = new AsyncCommand(Vegan5);
            //Vegan6Command = new AsyncCommand(Vegan6);

            Wl1Command = new AsyncCommand(Wl1);
            Wl2Command = new AsyncCommand(Wl2);
            Wl3Command = new AsyncCommand(Wl3);
            Wl4Command = new AsyncCommand(Wl4);
            Wl5Command = new AsyncCommand(Wl5);
            Wl6Command = new AsyncCommand(Wl6);
        }

        //  Weightgain
        async Task Wg1()
        {
            App.ms.SetRecipe("", "Chicken with asparagus, quinoa and thyme",
                "-  800 g chicken breast " + "\n" + "-  500 g green asparagus" + "\n" + "-  1 t tsm of oil " + "\n" + "-  2 carrots" + "\n" + "-  1.5 cup quinoa " + "\n" +
                "-  3 cups (750 ml) vegetable broth (possibly water + pepper and salt to taste)" + "\n" + "-  1 TB salt" + "\n" + "-  1/2 TB of ground black pepper" + "\n" + "-  2 garlic cloves" + "\n" +
                "-  čerstvá petržlenová vňať" + "\n" + "-  1/4 ČL kurkumy", "Pour the quinoa into a saucepan with 750 ml of broth or water and cook it softly until it absorbs all the liquid (about 15 minutes).", "In a larger saucepan, fry half the chopped red onions in the hot oil.",
                "Then we also add to small pieces chopped chicken breast and stir them for 2 minutes.", "Add to small pieces chopped asparagus, grated carrots and cook it uncovered for about 15 minutes.", "Then we also add salt, pressed garlic, thyme, black pepper, the remaining half of the chopped red onion to the food and cook it for another 5-7 minutes, stirring occasionally.",
                "When the meat is cooked properly, we serve it together with the cooked quinoa and recommend supplementing it with homemade yogurt tartar sauce");
            await Application.Current.MainPage.Navigation.PushAsync(new Recipe1View());
        }
        async Task Wg2()
        {
            App.ms.SetRecipe("", "Baked pasta with tofu and tuna",
                "-  500 g wholemeal pasta  " + "\n" + "-  700 g tomato puree" + "\n" + "-  400 g tofu" + "\n" + "-  1 grated zucchini" + "\n" + "-  300 g tuna in its own juice " + "\n" +
                "-  150 g grated mozzarella (lower in fat)" + "\n" + "-  50 g corn" + "\n" + "-  2 garlic cloves" + "\n" + "-  1 TB oregano" + "\n" + "-  1 TB salt" + "\n" + "-  •	1/2 TB of ground black pepper" + "\n" +
                "-  fresh basil (optional)" + "\n", "	Cook the pasta in boiling, salted water almost until soft (cook it for about 10 minutes). Then we will precedent them.", "	In a large saucepan or bowl, mix the cooked pasta together with grated zucchini, chopped tofu, juice-free tuna, grated cheese and corn.",
                "	We also add tomato puree, spices, salt, pressed garlic, fresh basil if you are interested and mix everything together thoroughly.", "	Transfer the prepared pasta to a larger baking mould (measuring about 35x25 cm).", "5.	Bake the pasta for 30 minutes at 190 degrees. They will be stiff only after lying in the refrigerator.",
                "Enjoy !");
            await Application.Current.MainPage.Navigation.PushAsync(new Recipe1View());
        }
        async Task Wg3()
        {
            App.ms.SetRecipe("", "Fit vegetable musaka,",
                "-  500 g carrots " + "\n" + "-  500 g white pumpkin (ordinary or patizone)" + "\n" + "-  500 g aubergine" + "\n" + "-  400 g potatoes" + "\n" + "-  400 g tomato puree" + "\n" +
                "-  21 onion" + "\n" + "-  1 tbsp olive oil " + "\n" + "-  4 garlic cloves" + "\n" + "-  1 TB salt" + "\n" +
                "-  1/2 TB of ground black pepper" + "\n" + "-  1/4 TB white pepper", "We clean the carrots and pumpkin, remove the pumpkin seeds and grated them finely.In a larger saucepan, lightly fry the finely chopped onions in the vitreous onions on the hot oil.", "Add the grated vegetables and stir for 2 minutes.Then salt the vegetables, season, add the pressed cloves of garlic and pour in the tomato puree. Stirring occasionally, cook it softly, about 15 minutes.",
                "In time, we clean the potatoes and cut them into thin slices (about 0.5 cm thick).We put the potatoes at the bottom of the baking mould (measuring about 35 x 20 cm).", "We put washed on a layer of potatoes and also on thinly chopped aubergine.Layer the cooked carrot-pumpkin mixture on the aubergine part and press and line it thoroughly.", "Mix the milk in a mug along with 2 tablespoons of flour.In a smaller saucepan, melt the butter and then add the milk mixture to it.", "6.	Cook the bechamel for 2 minutes, then sprinkle grated parmesan into it. Stir it into thickening and let it boil over.Pour the finished bechamel on top of the musaka. Cover the musak from the top with foil and bake it for 45-50 minutes at 220 degrees. After half an hour, we can take the foil off.");
            await Application.Current.MainPage.Navigation.PushAsync(new Recipe1View());
        }
        async Task Wg4()
        {
            App.ms.SetRecipe("", "Perfect cauliflower for the Indian way",
                "-  1 larger cauliflower " + "\n" + "-  400 ml coconut milk (dense type - from a can or cardboard)" + "\n" + "-  400g peeled, chopped tomatoes" + "\n" + "-  250 g SOS Basmati rice " + "\n" + "-  1 onion" + "\n" +
                "-  2 garlic cloves" + "\n" + "-  1 t t tsm butter (or oil)" + "\n" + "-  1 tbs ply with fresh ginger" + "\n" + "-  1 tsed garam masala pepper" + "\n" +
                "-  1 TB curry spices" + "\n" + "-  1/4 TB turmeric", "Wash the cauliflower, break it into small roses and place it on a baking tray lined with baking paper.Bake the cauliflower for 10 minutes at 220 degrees.", "Rinse the rice under cold water, pour it with twice the volume of water, salt to taste and cook until soft (roughly 13 minutes).In a larger saucepan, fry the chopped onions on the hot butter (or oil).",
                "Then add the pressed cloves of garlic, spices, grated ginger, salt and stir for a minute.Then add the coconut milk, peeled tomatoes and let the sauce boil into the sauce.", "After pinching, I recommend blending the sauce with a rod blender.Then add the baked cauliflower to the boiling sauce and cook it for 5 minutes", "Serve the finished cauliflower with the sauce together with the cooked rice and finally decorate the dish with parsley.", "ENJOY !");
            await Application.Current.MainPage.Navigation.PushAsync(new Recipe1View());
        }
        async Task Wg5()
        {
            App.ms.SetRecipe("", "Cod on oranges with batatas",
                "-  1 kg of batates " + "\n" + "-  800 g cod fillets (chilled or thawed)" + "\n" + "-  2 oranges (zest + juice)" + "\n" + "- 1 tsp soy sauce " + "\n" + "-  1 tbsp olive oil " + "\n" +
                "-  parsley (to taste)" + "\n" + "-  1 TB of Dižón mustard" + "\n" + "-  1/2 TB salt" + "\n" + "-  1/2 TB of ground black pepper" + "\n" +
                "-  a pinch of ginger (minced or fresh)" + "\n" + "-  1 TB of garlic pepper", "Pierce the bats with a fork and bake them in the oven on a baking tray lined with baking paper until soft. Bake them for about 30-40 minutes at 220 degrees, depending on their size.", "In a grill frying pan (or plain) we heat olive oil.", "the cod fillets are very moist, we dry it as much as possible using a paper towel",
                "Then put the cod fillets in the pan and grill them for 4-5 minutes from both sides until golden brown.In a saucepan or deep pan, meanwhile, mix the honey with the mustard, soy sauce, orange juice and zest, spices and salt, and let the sauce boil.", "	Finally, put the grilled cod in a boiling sauce and let them stand together for 2 minutes, out of flame.", "6.	Peel the baked bats and can either cut them into cubes or squeeze them into puree and serve them together with the cod, sprinkle with the sauce and sprinkled with parsley.");
            await Application.Current.MainPage.Navigation.PushAsync(new Recipe1View());
        }
        async Task Wg6()
        {
            App.ms.SetRecipe("", "Chicken with asparagus, quinoa and thyme",
                "-  800 g chicken breast " + "\n" + "-  500 g green asparagus" + "\n" + "-    1 t tsm of oil" + "\n" + "- 1 t tsm of oil " + "\n" + "-  2 carrots" + "\n" +
                "-  1.5 cup quinoa " + "\n" + "-  3 cups (750 ml) vegetable broth (possibly water + pepper and salt to taste)" + "\n" + "- 1 TB salt" + "\n" + "- 1/2 TB of ground black pepper" + "\n" +
                "-  2 garlic cloves" + "\n" + "-  1 Thyme (fresh or dried)", "Pour the quinoa into a saucepan with 750 ml of broth or water and cook it softly until it absorbs all the liquid (about 15 minutes).", "In a larger saucepan, fry half the chopped red onions in the hot oil.", "Then we also add to small pieces chopped chicken breast and stir them for 2 minutes.", "Add to small pieces chopped asparagus, grated carrots and cook it uncovered for about 15 minutes.", "Then we also add salt, pressed garlic, thyme, black pepper, the remaining half of the chopped red onion to the food and cook it for another 5-7 minutes, stirring occasionally.", "When the meat is cooked properly, we serve it together with the cooked quinoa and recommend supplementing it with homemade yogurt tartar sauce.");
            await Application.Current.MainPage.Navigation.PushAsync(new Recipe1View());
        }

        //  Breakfast
        async Task Br1()
        {
            App.ms.SetRecipe("Meal1.jpg", "Spinach shakshukaa",
                "-  4 large eggs" + "\n" + "-  100 g baby spinach" + "\n" + "-  400 g chopped, peeled tomatoes (from tin)" + "\n" + "-   1 onion" + "\n" + "-  1 TB of olive oil" + "\n" +
                "-  2 cloves garlic" + "\n" + "-  1/2 tb salt" + "\n" + "-  1/4 TB of ground red pepper1/4 ČL" + "\n" + "-  a pinch of chilli pepper" + "\n" +
                "-  pinch of ground cumin" + "\n" + "-  1/4 ČL kurkumy", "In a larger frying pan, fry the finely chopped onions in the vitreous in the hot oil.", "Then add chopped tomatoes with brine, pressed cloves of garlic, all spices, salt, washed baby spinach, parsley and stir the mixture for 3 minutes.",
                "Then we make 4 wells into the tomato sauce, into which we break the eggs.", "Cover the pan with a lid and cook the eggs in the sauce on a weaker flame for 10 minutes, or until sufficiently cooked.", "Enjoy !", "6");
            await Application.Current.MainPage.Navigation.PushAsync(new Recipe1View());
        }
        async Task Br2()
        {
            App.ms.SetRecipe("Meal2.jpg", "Fit pizza snails with tuna", "-  2 x 80 g tuna in its own juice" + "\n" + "-  150 g of lavasha (1 slice) or tortilla" + "\n" + "-  0 g tomato purée" + "\n" +
                "-  1 pl of water" + "\n" + "-  100 g grated mozzarella" + "\n" + "-  50 g corn" + "\n" + "-  1 garlic clove" + "\n" + "-  1/3 TB oregano" + "\n" + "-  1 PL pizza pepper" + "\n",
                "Cut the lavasha slice in half.", "In a bowl, mix the tomato purée with a tablespoon of water, oregano, pressed garlic clove and pizza pepper.", " Rub the lavash with the tomato mixture.",
                "Place the corn, grated mozzarella and juice-free tuna on top, which we crush with the help of a fork.", "Roll the dough firmly from the edge and cut it into wheels (approximately 3 cm thick).",
                "Place the chopped snails on a baking tray lined with baking paper and bake them for about 7 minutes at 180 degrees.");
            await Application.Current.MainPage.Navigation.PushAsync(new Recipe1View());
        }
        async Task Br3()
        {
            App.ms.SetRecipe("", "Vegan stuffed omelette", "-  300 g bio tofu" + "\n" + "-  3 PL deli yeast" + "\n" + "-  2 TB cornstarch" + "\n" + "-  4 PL hummus" + "\n" + "-  2 cloves garlic" + "\n" + "-  1 red onion" + "\n" +
                "-  60 ml vegetable milk" + "\n" + "-  salt and black ground pepper (to taste)" + "\n" + "-  2 tbsp olive oil " + "\n",
                "Put the tofu, delicacy yeast, cornstarch, garlic, humus, milk, salt and pepper in a food processor and romix until smooth. If necessary, add 1-2 tablespoons of water. The dough should be thinner, similar to pancake dough.",
                "In a large frying pan, heat the olive oil and fry the finely chopped onions on it.", "Pour half the blended mixture into a pan with the onion and pour into the shape of a pancake.",
                "Bake for 3-4 minutes on a medium heat. To bake the omelette nicely, turn it over and bake for another 1-2 minutes.", "Fill half the omelette with your favorite filling and cover with the other side.",
                "Bake for another 2 minutes, pushing the omelette from the top. We will also prepare a second omelette from the rest of the dough.");
            await Application.Current.MainPage.Navigation.PushAsync(new Recipe1View());
        }
        async Task Br4()
        {
            App.ms.SetRecipe("", "Vegan tofu ,scrambled eggs, without eggs", "-  450 g bio tofu" + "\n" + "-  3-4 PL water" + "\n" + "-  garlic spices" + "\n" + "-  onion spices" + "\n" + ".-  a pinch of turmeric" + "\n" +
                "-  a pinch of sea salt" + "\n" + "-  a piece of parsley" + "\n" + "-  1 TB coconut oil" + "\n", "Make tofu into small pieces", "On a gentle flame, heat a non-stick frying pan, which we rub with a little coconut oil.",
                "Add the overmade tofu to the pan, which we sprinkle with salt and pepper to taste.", "While stirring constantly, fry the tofu pieces until golden brown (about 4-5 minutes), pouring them with a few tablespoons of water so that they do not perch.",
                "Tofu scrambled eggs can be served, for example, with salad or wholemeal pastries.", "Enjoy !");
            await Application.Current.MainPage.Navigation.PushAsync(new Recipe1View());
        }

        async Task Br5()
        {
            App.ms.SetRecipe("", "Salmon spread with cottage cheese from 3 ingredients",
                "-  200 g cottage cheese " + "\n" + "-  170 g salmon fillets in olive oil" + "\n" + "-  2 garlic cloves" + "\n",
                "In a smaller bowl, mix the cottage cheese free of liquid brine, oil-free salmon fillets and squeezed garlic.",
                "Stir in the mixture with a fork to unite. If you are interested, you can salt it to taste.",
                "We layer the finished spread on the pastry and serve it ideally as much as possible.", "Enjoy !", "5", "6");
            await Application.Current.MainPage.Navigation.PushAsync(new Recipe1View());
        }

        async Task Br6()
        {
            App.ms.SetRecipe("", "Quick breakfast porridge",
                "-  4 large eggs " + "\n" + "-  100 g baby spinach" + "\n" + "- 400 g chopped, peeled tomatoes (of tin)" + "\n" + "- 1 onion" + "\n" + "- 1 TB of olive oil" + "\n" +
                "-  2 garlic cloves" + "\n" + "- 1/2 TB salt" + "\n" + "-  1/4 TB ground pepper" + "\n" + "-  1/4 TB of ground black pepper" + "\n" +
                "-  a pinch of chilli pepper" + "\n" + "-  pinch of ground cumin" + "-  handful of parsley" + "\n", "1", "2", "3", "4", "5", "6");
            await Application.Current.MainPage.Navigation.PushAsync(new Recipe1View());
        }

        async Task Vegan1()
        {
            App.ms.SetRecipe("", "Beetroot soup with chilli and sprouts  ",
                "-  300 g cooked beetroot (vacuum packed)  " + "\n" + "-  300 g carrots" + "\n" + "-  500 ml boiling water" + "\n" + "-  200 ml coconut milk (light)  " + "\n" + "-  1 tbsp olive oil " + "\n" +
                "-  1 onion " + "\n" + "-  2 cloves garlic " + "\n" + "-  crushed chili peppers (to taste) " + "\n" + "-  1/2 tb salt " + "\n" +
                "-  ground black pepper (to taste) " + "\n" + "-  thyme (to taste) ", "In a saucepan, fry the chopped onions and garlic in the hot oil. ", "Add the chilli, thyme, ground black pepper, chopped beetroot, finely chopped carrots and roast for a minute. ", "Pour the vegetables with boiling water and cook them for 15-20 minutes, until the carrots soften. ", "Then blend the soup until smooth with a rod blender (or a blender). ", "Then add coconut milk, salt to the soup, stir it and let it boil. ", "Serve the finished soup sprinkled with sprouts. ");
            await Application.Current.MainPage.Navigation.PushAsync(new Recipe1View());
        }
        async Task Vegan2()
        {
            App.ms.SetRecipe("", "Tofu on orange sauce (vegan) ",
                "-  300 g bio tofu (no flavor)   " + "\n" + "-  3 tsad cornstarch " + "\n" + "-  200 ml orange juice" + "\n" + "-  60 ml soy sauce   " + "\n" + "-  2 PL maple syrup   " + "\n" +
                "-  2 tss of rice vinegar (you can skip) " + "\n" + "-  4 garlic cloves " + "\n" + "-  1 TB chilli sauce (e.g. Sriracha)  " + "\n" + "-  1/4 TB of ground ginger " + "\n" +
                "-  2 pl of water " + "\n" + "-  2 tss cornstarch  ", "Preheat the oven to 200 degrees. Line the baking tray with baking paper. Use paper towels to get rid of tofu as much water as possible. ", " Then cut it into 2 cm cubes, which we wrap with 3 tablespoons of cornstarch. Place the prepared tofu on a baking tray and bake for 20-25 minutes, in the middle of baking the tofu.  ", " Meanwhile, in a deep frying pan, mix all the ingredients for the sauce and stir them with a whisk. When the tofu is baked, we start heating the sauce pan over a medium heat until it starts to boil. Stir occasionally.  ",
                "Add the tofu to the boiling sauce and mix well to wrap each piece of tofu. Once the desired consistency has been reached, we remove the pan from the stove. If you like a thinner sauce, you can add 1-2 tablespoons of water. ", "Then add coconut milk, salt to the soup, stir it and let it boil. ", "Serve with jasmine rice or other sided and garnish with sesame seeds and green onions. ");
            await Application.Current.MainPage.Navigation.PushAsync(new Recipe1View());
        }
        async Task Vegan3()
        {
            App.ms.SetRecipe("", "Healthy plum-apple crumble  ",
                "-  400 g fresh plums   " + "\n" + "-  2 smaller apples " + "\n" + "-  2 tbsp lemon juice" + "\n" + "-  2 tss of softened coconut oil (or butter)   " + "\n" + "-   60 g wholemeal/seasoned flour (possibly almond) " + "\n" +
                "-  1/2 TB baking powder " + "\n" + "-  1-2 PL of xylitol (or a little 1000)  " + "\n" + "-  10 g coconut " + "\n" + "- " + "\n" +
                "-  ground black pepper (to taste) " + "\n" + "-  thyme (to taste) ", " Clean the fruit and cut it into smaller pieces. ", "Place it at the bottom of two smaller baking bowls or one large bowl. ", "Drizzle the fruit with lemon juice. ", " In a bowl, stir in the softened coconut oil or butter, any flour, sweetener and baking powder by hand. ", "Crush the formed solid dough into the prepared fruit. ", "Sprinkle crumble with grated coconut and bake it for about 30 minutes at 190 degrees until golden brown. ");
            await Application.Current.MainPage.Navigation.PushAsync(new Recipe1View());
        }
    async Task Vegan4()
    {
        App.ms.SetRecipe("", "Quick nut pasta from 4 ingredients (chickpeas, gluten-free) ",
            "-  250 g chickpea pasta (fussili) " + "\n" + "- 100 g walnuts " + "\n" + "-  2 TSAs (30 g) of butter or oil " + "\n" + "-  2 TB (40 g) honey or maple syrup  ",
            " In a saucepan we let the water boil.", "Add chickpea pasta to the water and cook them until soft for about 8 minutes. ", "Blend the nuts finely in a blender or cleaver. ", "Mix the pasta and mix with the walnuts, butter and honey. ", "I recommend serving pasta immediately while it is soft and warm. ", "ENJOY !");
        await Application.Current.MainPage.Navigation.PushAsync(new Recipe1View());
    }
    async Task Vegan5()
    {
        App.ms.SetRecipe("", "Tofu on orange sauce (vegan)  ", "-   300 g bio tofu (no flavor)   " + "\n" + "-  3 tsad cornstarch " + "\n" + "-  200 ml orange juice " + "\n" + "-  60 ml soy sauce   " + "\n" + "-   2 PL maple syrupÂ  " + "\n" +
            "- 2 tss of rice vinegar (you can skip)  " + "\n" + "-   4 garlic cloves  " + "\n" + "-  11 TB chilli sauce (e.g. Sriracha) " + "\n" + "-  1/4 TB of ground ginger " + "\n" +
            "-  2 pl of water  " + "\n" + "-  2 tss cornstarch ", " Preheat the oven to 200 degrees. Line the baking tray with baking paper. Use paper towels to get rid of tofu as much water as possible.", "Then cut it into 2 cm cubes, which we wrap with 3 tablespoons of cornstarch. Place the prepared tofu on a baking tray and bake for 20-25 minutes, in the middle of baking the tofu. ",
            " Meanwhile, in a deep frying pan, mix all the ingredients for the sauce and stir them with a whisk. When the tofu is baked, we start heating the sauce pan over a medium heat until it starts to boil. Stir occasionally.", "Add the tofu to the boiling sauce and mix well to wrap each piece of tofu. Once the desired consistency has been reached, we remove the pan from the stove. If you like a thinner sauce, you can add 1-2 tablespoons of water.", " Serve with jasmine rice or other sided and garnish with sesame seeds and green onions.", "ENJOY!");
        await Application.Current.MainPage.Navigation.PushAsync(new Recipe1View());
    }

        async Task Wl1()
        {
            App.ms.SetRecipe("", "Low-carb chicken breast with carrots and cauliflower ", "-   300 g bio tofu (no flavor)   " + "\n" + "-  3 tsad cornstarch " + "\n" + "-  200 ml orange juice " + "\n" + "-  60 ml soy sauce   " + "\n" + "-   2 PL maple syrup  " + "\n" +
                "- 700g chicken breast  " + "\n" + "-   1 onion  " + "\n" + "-  200g carrots  " + "\n" + "-  2 tbsp lemon juice  " + "\n" +
                "-  1 tbs p.m. garlic pepper   " + "\n" + "-  1 TB of ground red pepper " + "\n" +"-  1 TB salt  " + "\n" + "-  a pinch of turmeric " + "\n" + "-  1 larger cauliflower   " + "\n" + "-   2 tss water ", "In a saucepan, lightly fry the finely chopped onions in a saucepan and then add the chopped chicken breast to the cubes. ", "Mix the contents of the saucepan thoroughly, pour a little water, cover and sie for 20 minutes. ", " Finally, add the spices, salt, lemon juice and grated carrots. ", "We cook everything together for another 5 minutes and wean it off the heat. ", " In the meantime, we disassemble the cauliflower into roses and mix it in parts into  a blender. If you are interested, we can cut the cauliflower into small pieces with the help of a knife, but we will achieve a more subtle result by using a blender.Put the chopped cauliflower in a deeper pan, add 2 tablespoons of water, salt, season and cook it for about 10 minutes, stirring occasionally, until golden in colour begins to catch. ", "Then we wean the cauliflower from the heat and serve together with the finished meat. ");
            await Application.Current.MainPage.Navigation.PushAsync(new Recipe1View());
        }
        async Task Wl2()
        {
            App.ms.SetRecipe("", "Fit chicken breast on spinach  ", "-   500g chicken breast    " + "\n" + "-   300 g bio tofu (no flavor)   " + "\n" + "- 500g frozen spinach  " + "\n" + "-  1 onion  " + "\n" + "-  3 tsp soy sauce    " + "\n" + "-   3 garlic cloves  " + "\n" +
                "- 1 TB salt1 TB turmeric   " + "\n" + "-   1 TB parsley  " + "\n" + "-  grated mozzarella  " + "\n" + "Let the spinach freeze. ", "In a larger saucepan, lightly fry the finely chopped onions on melted coconut oil. ", " Add to the cubes chopped chicken breast, stir, salt, season, pour with 150ml water and sift for about 20 minutes, stirring occasionally. ", "When the meat slowly crumbles, add the soy sauce, pressed garlic cloves and def frozen spinach. ", " Stir the mixture until we remove it from excess water.Finally, we can also add corn and grated mozzarella. ", "We serve the finished food warm along with rice, couscus, potatoes or separately. ", "");
            await Application.Current.MainPage.Navigation.PushAsync(new Recipe1View());
        }

        async Task Wl3()
        {
            App.ms.SetRecipe("", "Fit cauliflower cake   ", "-   1 cauliflower    " + "\n" + "- 4 eggs  " + "\n" + "- 3 handfuls of spinach   " + "\n" + "-  40g dried tomatoes  " + "\n" + "-  1/2 TB salt   " + "\n" +
                "- 1/2 TB of ground black pepper    " + "\n" + "-  1 tbs p.m. garlic pepper   ", "We disassemble the cauliflower into small roses and blend it together with the eggs, cottage cheese, pepper, sea salt and spinach as smoothly as possible in the blender. ", "Finally, we add dried tomatoes to the dough, chopped finely. ", "Pour the dough into a silicone or baking paper lined baking dish and bake for about 60 minutes on 180 degrees until the dough has solidtened and melted. ", "Allow the cake to cool for at least 10 minutes before chopping. ", " ENJOY!", "6");
            await Application.Current.MainPage.Navigation.PushAsync(new Recipe1View());
        }

        async Task Wl4()
        {
            App.ms.SetRecipe("", "Fit Thai roasted rice", "-   300 g bio tofu (no flavor)   " + "\n" + "-  3 tsad cornstarch " + "\n" + "-  200 ml orange juice " + "\n" + "-  60 ml soy sauce   " + "\n" + "-   2 PL maple syrup  " + "\n" +
                "- 2 tss of rice vinegar (you can skip)  " + "\n" + "-   4 garlic cloves  " + "\n" + "-  11 TB chilli sauce (e.g. Sriracha) " + "\n" + "-  2 garlic cloves  ", "In a bowl, mix together the soy sauce, lime juice, pressed garlic cloves, peanuts, chopped spring onions and finely chopped coriander. ", "Wash, clean and disassemble cauliflower into roses. Mix the pieces of cauliflower in parts in a blender into fine. Alternatively, we'll chop it with a knife. ", "In a frying pan, heat the coconut oil, on which we fry the cauliflower rice for 3 minutes. ", "V strede panvice si urobíme medzeru, do ktorej vylejeme rozmiešané vajíčka, necháme ich na mieste zhruba 30 sekúnd a následne ich rozmiešame s karfiolom. ", "Keď sú vajíčka hotové, na panvicu vylejeme pripravenú omáčku a „ryžovú“ zmes popražíme ešte 3 minúty, dokým karfiól úplne nezmäkne. ", "Jedlo podávame teplé a pred servírovaním ho môžeme posypať nadrobenými orechami a poliať limetkovou šťavou. ");
            await Application.Current.MainPage.Navigation.PushAsync(new Recipe1View());
        }

        async Task Wl5()
        {
            App.ms.SetRecipe("", "Dietary cauliflower with bryndza   ", "-   1 cauliflower    " + "\n" + "-  2 eggs  " + "\n" + "-  4 tbsping fresh coriander  " + "\n" + "-  50 g peanuts (or cashew nuts)    " + "\n" + "-   3 tsp soy sauce   " + "\n" +
                "- juice of 1⁄2 limes  " + "\n" + "-   Spring onions   " + "\n" + "-  1 TB coconut oil   " + "\n" + "-  1/4 TB of ground ginger " + "\n" +
                "-  2 pl of water  " + "\n" + "-  2 tss cornstarch ", "In a larger saucepan we let the water boil. ", "We clean the cauliflower, wash and disassemble into roses.  ", "We put the cauliflower roses boil over steam for 10 minutes, cook them until soft. ", "Then we remove them from the pot and cut them into small gnocchi. ", "Put the cauliflower gnocchi in a warm saucepan without water, where we mix them with bryndza and cottage cheese. If the bryndza does not dissolve, we can heat everything together on a weak flame.In a hot frying pan, fry the fine cubes of chopped ham into a golden brown. If necessary, spray the pan in front with a little oil. ", "Serve cauliflower gnocchi with toasted ham and we can also add chives. ");
            await Application.Current.MainPage.Navigation.PushAsync(new Recipe1View());
        }

        async Task Wl6()
        {
            App.ms.SetRecipe("", "Baked aubergine wheels   ", "-   1 medium aubergine    " + "\n" + "-  50 g tomato puree (or purée)  " + "\n" + "- 40g grated mozzarella (or other cheese)   " + "\n" + "-  100 g quality ham   " + "\n" + "- fresh basil (to taste)   " + "\n" +
                "- cherry tomatoes (to taste)   " + "\n" + "-  sea salt  " + "\n" + "-  garlic spices  ", "Wash the aubergine and cut it into wheels (not thick or too thin). ", "Place the chopped eggplant on a baking tray lined with baking paper.  ", " Lightly salt the aubergine wheels and bake for 15 minutes at 210 degrees. ", "Then remove the eggplant from the oven and rub each wheel with tomato puree (possibly tomato purée diluted with water), put pieces of ham on them, sprinkle with cheese and finally decorate with cherry tomatoes and basil. We can also mix salt and garlic pepper into the tomato puree. ", " Bake the eggplant for 5-10 minutes at 250 degrees until the cheese starts to catch a golden colour. ", "ENJOY!");
            await Application.Current.MainPage.Navigation.PushAsync(new Recipe1View());
        }

    }
}