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

    }
}