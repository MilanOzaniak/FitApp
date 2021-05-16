using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using FitApp.Views;
using MvvmHelpers.Commands;
using Xamarin.Forms;
using FitApp.ViewModels;
using FitApp.Services;
using System.Collections.ObjectModel;

namespace FitApp.ViewModels
{
    public class WorkoutsViewModel : ContentPage
    {
        //ARMS
        public AsyncCommand BeginnerArmsCommand { get; set; }
        public AsyncCommand IntermediateArmsCommand { get; set; }
        public AsyncCommand AdvancedArmsCommand { get; set; }

        //ABS
        public AsyncCommand BeginnerAbsCommand { get; set; }
        public AsyncCommand IntermediateAbsCommand { get; set; }
        public AsyncCommand AdvancedAbsCommand { get; set; }

        //CHEST
        public AsyncCommand BeginnerChestCommand { get; set; }
        public AsyncCommand IntermediateChestCommand { get; set; }
        public AsyncCommand AdvancedChestCommand { get; set; }

        //LEGS
        public AsyncCommand BeginnerLegsCommand { get; set; }
        public AsyncCommand IntermediateLegsCommand { get; set; }
        public AsyncCommand AdvancedLegsCommand { get; set; }

        //SHOULDERSANDBACK
        public AsyncCommand BeginnerShouldersandBackCommand { get; set; }
        public AsyncCommand IntermediateShouldersandBackCommand { get; set; }
        public AsyncCommand AdvancedShouldersandBackCommand { get; set; }

        

        public WorkoutsViewModel()
        {
            BeginnerArmsCommand = new AsyncCommand(BeginnerArms);
            IntermediateArmsCommand = new AsyncCommand(IntermediateArms);
            AdvancedArmsCommand = new AsyncCommand(AdvancedArms);

            BeginnerAbsCommand = new AsyncCommand(BeginnerAbs);
            IntermediateAbsCommand = new AsyncCommand(IntermediateAbs);
            AdvancedAbsCommand = new AsyncCommand(AdvancedAbs);

            BeginnerLegsCommand = new AsyncCommand(BeginnerLegs);
            IntermediateLegsCommand = new AsyncCommand(IntermediateLegs);
            AdvancedLegsCommand = new AsyncCommand(AdvancedLegs);

            BeginnerShouldersandBackCommand = new AsyncCommand(BeginnerShoulderAndBack);
            IntermediateShouldersandBackCommand = new AsyncCommand(IntermediateShoulderAndBack);
            AdvancedShouldersandBackCommand = new AsyncCommand(AdvancedShoulderAndBack);

            BeginnerChestCommand = new AsyncCommand(BeginnerChest);
            IntermediateChestCommand = new AsyncCommand(IntermediateChest);
            AdvancedChestCommand = new AsyncCommand(AdvancedChest);
        }

        //ARMS
        async Task BeginnerArms()
        {
            App.ListOfWorkouts = new ObservableCollection<WorkoutService> {
                new WorkoutService { W1 = "ARM RAISES", T1 = "0:30" },
                new WorkoutService { W1 = "SIDE ARM RAISES", T1 = "0:30" },
                new WorkoutService { W1 = "TRICEPS DIPS", T1 = "x10" },
                new WorkoutService { W1 = "ARM CIRCLES CLOCKSWISE", T1 = "0:30" },
                new WorkoutService { W1 = "ARM CIRCLES COUNTERCLOCKWISE", T1 = "00:30" },
                new WorkoutService { W1 = "DIAMOND PUSH-UPS", T1 = "x6" },
                new WorkoutService { W1 = "JUMPING JACKS", T1 = "0:30" },
                new WorkoutService { W1 = "CHEST PRESS PULSE", T1 = "0:16" },
                new WorkoutService { W1 = "LEG BARBELL CURL LEFT", T1 = "x8" },
                new WorkoutService { W1 = "LEG BARBELL CURL RIGHT", T1 = "x8" },
                new WorkoutService { W1 = "PUNCHES", T1 = "0:30" },
                new WorkoutService { W1 = "PUSH-UPS ", T1 = "x10" },
                new WorkoutService { W1 = "INCHWORMS", T1 = "x8" },
                new WorkoutService { W1 = "WALL PUSH-UPS ", T1 = "x12" },
                new WorkoutService { W1 = "TRICEPS STRECH LEFT", T1 = "0:30" },
                new WorkoutService { W1 = "TRICEPS STRECH RIGHT", T1 = "0:30" },
                new WorkoutService { W1 = "STANDING BICEPS STRETCH LEFT", T1 = "0:30" },
                new WorkoutService { W1 = "STANDING BICEPS STRETCH RIGHT", T1 = "0:30" },
            };
            await Application.Current.MainPage.Navigation.PushAsync(new WorkoutsPlanView());
        }

        async Task IntermediateArms()
        {
            App.ListOfWorkouts = new ObservableCollection<WorkoutService> {
                new WorkoutService { W1 = "ARM CIRCLES CLOCKSWISE", T1 = "0:30" },
                new WorkoutService { W1 = "ARM CIRCLES COUNTERCLOCKWISE", T1 = "0:30" },
                new WorkoutService { W1 = "FLOOR TRICEPS DIPS", T1 = "x14" },
                new WorkoutService { W1 = "MILITARY PUSH-UPS", T1 = "x12" },
                new WorkoutService { W1 = "LEG BARBELL CURL LEFT", T1 = "x12" },
                new WorkoutService { W1 = "LEG BARBELL CURL RIGHT", T1 = "x12" },
                new WorkoutService { W1 = "FLOOR TRICEPS DIPS", T1 = "x12" },
                new WorkoutService { W1 = "MILITARY PUSH-UPS", T1 = "x10" },
                new WorkoutService { W1 = "ALTERNATING HOOKS", T1 = "0:30" },
                new WorkoutService { W1 = "PUSH-UP & ROTATION", T1 = "x10" },
                new WorkoutService { W1 = "LEG BARBELL CURL LEFT", T1 = "x10" },
                new WorkoutService { W1 = "LEG BARBELL CURL RIGHT", T1 = "x10" },
                new WorkoutService { W1 = "SKIPPING WITHOUT ROPE", T1 = "0:30" },
                new WorkoutService { W1 = "PUSH-UPS", T1 = "x14" },
                new WorkoutService { W1 = "BURPEES", T1 = "x10" },
                new WorkoutService { W1 = "ARM SCISSORS", T1 = "0:30" },
                new WorkoutService { W1 = "SKIPPING WITHOUT ROPE", T1 = "0:30" },
                new WorkoutService { W1 = "PUSH-UPS", T1 = "x12" },
                new WorkoutService { W1 = "BURPEES", T1 = "x10" },
                new WorkoutService { W1 = "TRICEPS STRECH LEFT", T1 = "0:30" },
                new WorkoutService { W1 = "TRICEPS STRECH RIGHT", T1 = "0:30" },
                new WorkoutService { W1 = "STANDING BICEPS STRETCH LEFT", T1 = "0:30" },
                new WorkoutService { W1 = "STANDING BICEPS STRETCH RIGHT", T1 = "0:30" },
            };
            await Application.Current.MainPage.Navigation.PushAsync(new WorkoutsPlanView());
        }

        async Task AdvancedArms()
        {
            App.ListOfWorkouts = new ObservableCollection<WorkoutService> {
                new WorkoutService { W1 = "ARM CIRCLES CLOCKSWISE", T1 = "0:30" },
                new WorkoutService { W1 = "ARM CIRCLES COUNTERCLOCKWISE ", T1 = "0:30" },
                new WorkoutService { W1 = "SKIPPING WITHOUT ROPE ", T1 = "0:30" },
                new WorkoutService { W1 = "LEG BARBELL CURL LEFT ", T1 = "x16" },
                new WorkoutService { W1 = "LEG BARBELL CURL RIGHT ", T1 = "x16" },
                new WorkoutService { W1 = "BURPEES", T1 = "x16" },
                new WorkoutService { W1 = "LEG BARBELL CURL LEFT ", T1 = "x14" },
                new WorkoutService { W1 = "LEG BARBELL CURL RIGHT ", T1 = "x14" },
                new WorkoutService { W1 = "FLOOR TRICEPS DIPS ", T1 = "x18" },
                new WorkoutService { W1 = "ALTERNATING HOOKS ", T1 = "0:30" },
                new WorkoutService { W1 = "MILITARY PUSH UPS ", T1 = "x14" },
                new WorkoutService { W1 = "SHOULDER GATORS ", T1 = "x16" },
                new WorkoutService { W1 = "FLOOR TRICEP DIPS ", T1 = "x16" },
                new WorkoutService { W1 = "ALTERNATING HOOKS ", T1 = "0:30" },
                new WorkoutService { W1 = "LEG BARBELL CURL LEFT ", T1 = "x14" },
                new WorkoutService { W1 = "LEG BARBELL CURL RIGHT ", T1 = "x14" },
                new WorkoutService { W1 = "MILITARY PUSH UPS ", T1 = "x12" },
                new WorkoutService { W1 = "SHOULDER GATORS ", T1 = "x16" },
                new WorkoutService { W1 = "DOORWAY CURLS LEFT ", T1 = "x10" },
                new WorkoutService { W1 = "DOORWAR CURLS RIGHT ", T1 = "x10" },
                new WorkoutService { W1 = "MODIFIED PUSH-UP LOW HOLD ", T1 = "0:30" },
                new WorkoutService { W1 = "CHEST PRESS PULSE ", T1 = "0:30" },
                new WorkoutService { W1 = "PUSH-UP & ROTATION", T1 = "x10" },
                new WorkoutService { W1 = "TRICEPS STRECH LEFT ", T1 = "0:30" },
                new WorkoutService { W1 = "TRICEPS STRECH RIGHT ", T1 = "0:30" },
                new WorkoutService { W1 = "STANDING BICEPS STRETCH LEFT ", T1 = "0:30" },
                new WorkoutService { W1 = "STANDING BICEPS STRETCH RIGHT ", T1 = "0:30" },
            };
            await Application.Current.MainPage.Navigation.PushAsync(new WorkoutsPlanView());
        }

        //ABS

        async Task BeginnerAbs()
        {
            App.ListOfWorkouts = new ObservableCollection<WorkoutService> {
                new WorkoutService { W1 = "JUMPING JACKS", T1 = "0:30" },
                new WorkoutService { W1 = "ABDOMINAL CRUNCHES", T1 = "16x" },
                new WorkoutService { W1 = "RUSSIAN TWIST", T1 = "20x" },
                new WorkoutService { W1 = "MOUNTAIN CLIMBER", T1 = "16x" },
                new WorkoutService { W1 = "HEEL TOUCH", T1 = "20x" },
                new WorkoutService { W1 = "PLANK ", T1 = "0:30" },
                new WorkoutService { W1 = "ABDOMINAL CRUNCHES", T1 = "14" },
                new WorkoutService { W1 = "MOUNTAIN CLIMBER", T1 = "14x" },
                new WorkoutService { W1 = "HEEL TOUCH", T1 = "20x" },
                new WorkoutService { W1 = "LEG RAISES", T1 = "14x" },
                new WorkoutService { W1 = "PLANK", T1 = "0:30" },
                new WorkoutService { W1 = "COBRA STRETCH", T1 = "0:30" },
                new WorkoutService { W1 = "SPINE LUMBAR WIST STRETCH LEFT", T1 = "00:30" },
                new WorkoutService { W1 = "SPINE LUMBAR WIST STRETCH RIGHT", T1 = "0:30" },
            };
            await Application.Current.MainPage.Navigation.PushAsync(new WorkoutsPlanView());
        }

        async Task IntermediateAbs()
        {
        App.ListOfWorkouts = new ObservableCollection<WorkoutService> {
                new WorkoutService { W1 = "JUMPING JACKS", T1 = "0:30" },
                new WorkoutService { W1 = "HEEL TOUCH", T1 = "26x" },
                new WorkoutService { W1 = "CROSSOVER CRUNCH", T1 = "20x" },
                new WorkoutService { W1 = "MOUNTAIN CLIMBER", T1 = "20x" },
                new WorkoutService { W1 = "SIDE BRIDGES LEFT", T1 = "12x" },
                new WorkoutService { W1 = "SIDE BRIDGES RIGHT", T1 = "12x" },
                new WorkoutService { W1 = "BUTT BRIDGE", T1 = "20x" },
                new WorkoutService { W1 = "BICYCLE CRUNCHES ", T1 = "20x" },
                new WorkoutService { W1 = "V-UP", T1 = "20x" },
                new WorkoutService { W1 = "HEEL TOUCH", T1 = "26x" },
                new WorkoutService { W1 = "ABDOMINAL CRUNCHES", T1 = "20x" },
                new WorkoutService { W1 = "PLANK", T1 = "0:30" },
                new WorkoutService { W1 = "CROSSOVER CRUNCHES", T1 = "20x" },
                new WorkoutService { W1 = "LEG RAISES", T1 = "16x" },
                new WorkoutService { W1 = "BICYCLE CRUNCHES", T1 = "20X" },
                new WorkoutService { W1 = "PUSH-UP & ROTATION", T1 = "20X" },
                new WorkoutService { W1 = "SIDE PLANK RIGHT 00:30 ", T1 = "0:30" },
                new WorkoutService { W1 = "SIDE PLANK LEFT", T1 = "00:30" },
                new WorkoutService { W1 = "COBRA STRETCH", T1 = "00:30" },
                new WorkoutService { W1 = "SPINE LUMBAR WIST STRETCH LEFT", T1 = "00:30" },
                new WorkoutService { W1 = "SPINE LUMBAR WIST STRETCH RIGHT", T1 = "0:30" },
            };
            await Application.Current.MainPage.Navigation.PushAsync(new WorkoutsPlanView());
        }

        async Task AdvancedAbs()
        {
            App.ListOfWorkouts = new ObservableCollection<WorkoutService> {
                new WorkoutService { W1 = "JUMPING JACKS", T1 = "0:30" },
                new WorkoutService { W1 = "SIT-UPS", T1 = "20x" },
                new WorkoutService { W1 = "SIDE BRIDGES LEFT", T1 = "20x" },
                new WorkoutService { W1 = "SIDE BRIDGES RIGHT", T1 = "20x" },
                new WorkoutService { W1 = "ABDOMINAL CRUNCHES", T1 = "30x" },
                new WorkoutService { W1 = "BICYCLE CRUNCHES", T1 = "24x" },
                new WorkoutService { W1 = "SIDE PLANK RIGHT", T1 = "00:20" },
                new WorkoutService { W1 = "SIDE PLANK LEFT", T1 = "0:30" },
                new WorkoutService { W1 = "V-UP", T1 = "18x" },
                new WorkoutService { W1 = "PUSH-UP & ROTATION", T1 = "24x" },
                new WorkoutService { W1 = "RUSSIAN TWIST", T1 = "48x" },
                new WorkoutService { W1 = "ABDOMINAL CRUNCHES ", T1 = "28x" },
                new WorkoutService { W1 = "BUTT BRIDGE", T1 = "30x" },
                new WorkoutService { W1 = "HEEL TOUCH", T1 = "34x" },
                new WorkoutService { W1 = "MOUNTAIN CLIMBER", T1 = "30x" },
                new WorkoutService { W1 = "CROSSOVER CRUNCH", T1 = "24x" },
                new WorkoutService { W1 = "V-UP", T1 = "16x" },
                new WorkoutService { W1 = "PLANK ", T1 = "0:30" },
                new WorkoutService { W1 = "COBRA STRETCH ", T1 = "00:30" },
                new WorkoutService { W1 = "SPINE LUMBAR WIST STRETCH LEFT", T1 = "0:30" },
                new WorkoutService { W1 = "SPINE LUMBAR WIST STRETCH RIGHT", T1 = "0:30" },
            };
            await Application.Current.MainPage.Navigation.PushAsync(new WorkoutsPlanView());
        }

        //CHEST
        async Task BeginnerChest()
        {
            App.ListOfWorkouts = new ObservableCollection<WorkoutService> {
                new WorkoutService { W1 = "JUMPING JACKS", T1 = "0:30" },
                new WorkoutService { W1 = "INCLINE PUSH-UPS", T1 = "10x" },
                new WorkoutService { W1 = "PUSH-UPS ", T1 = "10x" },
                new WorkoutService { W1 = "WIDE ARM PUSH-UPS", T1 = "10x" },
                new WorkoutService { W1 = "ABDOMINAL CRUNCHES", T1 = "10x" },
                new WorkoutService { W1 = "TRICEPS DIPS", T1 = "8x" },
                new WorkoutService { W1 = "WIDE ARM PUSH-UPS", T1 = "10x" },
                new WorkoutService { W1 = "SIDE PLANK LEFT", T1 = "8x" },
                new WorkoutService { W1 = "INCLINE PUSH-UPS", T1 = "10x" },
                new WorkoutService { W1 = "TRICEPS DIPS", T1 = "10x" },
                new WorkoutService { W1 = "KNEE PUSH-UPS", T1 = "10x" },
                new WorkoutService { W1 = "COBRA STRETCH", T1 = "00:30" },
                new WorkoutService { W1 = "CHEST STRETCH", T1 = "00:30" },
            };
            await Application.Current.MainPage.Navigation.PushAsync(new WorkoutsPlanView());
        }

        async Task IntermediateChest()
        {
            App.ListOfWorkouts = new ObservableCollection<WorkoutService> {
                new WorkoutService { W1 = "JUMPING JACKS", T1 = "0:30" },
                new WorkoutService { W1 = "KNEE PUSH-UPS", T1 = "12x" },
                new WorkoutService { W1 = "PUSH-UPS ", T1 = "12x" },
                new WorkoutService { W1 = "WIDE ARM PUSH-UPS", T1 = "16x" },
                new WorkoutService { W1 = "HINDU PUSH-UPS", T1 = "10x" },
                new WorkoutService { W1 = "STAGGERED PUSH-UPS", T1 = "12x" },
                new WorkoutService { W1 = "PUSH-UP & ROTATION", T1 = "10x" },
                new WorkoutService { W1 = "HINDU PUSH-UPS", T1 = "10x" },
                new WorkoutService { W1 = "DECLINE PUSH-UPS", T1 = "12x" },
                new WorkoutService { W1 = "TRICEPS DIPS", T1 = "10x" },
                new WorkoutService { W1 = "STAGGERED PUSH-UPS", T1 = "12x" },
                new WorkoutService { W1 = "COBRA STRETCH", T1 = "00:30" },
                new WorkoutService { W1 = "CHEST STRETCH", T1 = "00:30" },
            };
            await Application.Current.MainPage.Navigation.PushAsync(new WorkoutsPlanView());
        }

        async Task AdvancedChest()
        {
            App.ListOfWorkouts = new ObservableCollection<WorkoutService> {
                new WorkoutService { W1 = "JUMPING JACKS", T1 = "0:30" },
                new WorkoutService { W1 = "ARM CIRCLES", T1 = "20x" },
                new WorkoutService { W1 = "SHOULDER STRETCH", T1 = "00:30" },
                new WorkoutService { W1 = "BURPEES", T1 = "12x" },
                new WorkoutService { W1 = "HINDU PUSH-UPS", T1 = "16x" },
                new WorkoutService { W1 = "STAGGERED PUSH-UPS", T1 = "16x" },
                new WorkoutService { W1 = "PUSH-UP & ROTATION", T1 = "10x" },
                new WorkoutService { W1 = "DIAMOND PUSH-UPS", T1 = "16x" },
                new WorkoutService { W1 = "BOX PUSH-UPS", T1 = "12x" },
                new WorkoutService { W1 = "SPIDERMAN PUSH-UPS", T1 = "20x" },
                new WorkoutService { W1 = "DECLINE PUSH-UPS", T1 = "12x" },
                new WorkoutService { W1 = "BURPEES", T1 = "10x" },
                new WorkoutService { W1 = "SHOULDER STRETCH", T1 = "00:30" },
                new WorkoutService { W1 = "COBRA STRETCH", T1 = "00:30" },
                new WorkoutService { W1 = "CHEST STRETCH", T1 = "00:30" },
            };
            await Application.Current.MainPage.Navigation.PushAsync(new WorkoutsPlanView());
        }

        //LEGS

        async Task BeginnerLegs()
        {
            App.ListOfWorkouts = new ObservableCollection<WorkoutService> {
               new WorkoutService { W1 = "BURPEES", T1 = "10x" },
               new WorkoutService { W1 = "JUMPING JACKS", T1 = "0:30" },
               new WorkoutService { W1 = "SQUATS", T1 = "12" },
               new WorkoutService { W1 = "SQUATS", T1 = "12" },
               new WorkoutService { W1 = "SIDE-LYING LEG LIFT LEFT ", T1 = "12x" },
               new WorkoutService { W1 = "SIDE-LYING LEG LIFT RIGHT", T1 = "12" },
               new WorkoutService { W1 = "SIDE-LYING LEG LIFT LEFT", T1 = "12x" },
               new WorkoutService { W1 = "SIDE-LYING LEG LIFT RIGHT", T1 = "12" },
               new WorkoutService { W1 = "BLACKWARD LUNGE", T1 = "14" },
               new WorkoutService { W1 = "BLACKWARD LUNGE", T1 = "14" },
               new WorkoutService { W1 = "DONKEY KICKS LEFT", T1 = "12x" },
               new WorkoutService { W1 = "DONKEY KICKS RIGHT", T1 = "12x" },
               new WorkoutService { W1 = "DONKEY KICKS LEFT", T1 = "12x" },
               new WorkoutService { W1 = "DONKEY KICKS RIGHT", T1 = "14x" },
               new WorkoutService { W1 = "LEFT QUAD STRETCH WITH WALL ", T1 = "00:30" },
               new WorkoutService { W1 = "RIGHT QUAD STRETCH WITH WALL", T1 = "00:30" },
               new WorkoutService { W1 = "KNEE TO CHEST STRETCH LEFT", T1 = "00:30" },
               new WorkoutService { W1 = "KNEE TO CHEST STRETCH RIGHT", T1 = "00:30" },
               new WorkoutService { W1 = "CALF STRETCH LEFT", T1 = "00:30" },
               new WorkoutService { W1 = "CALF STRETCH RIGHT", T1 = "00:30" },

            };
            await Application.Current.MainPage.Navigation.PushAsync(new WorkoutsPlanView());
        }

        async Task IntermediateLegs()
        {
            App.ListOfWorkouts = new ObservableCollection<WorkoutService> {
                new WorkoutService { W1 = "BURPEES", T1 = "10x" },
                new WorkoutService { W1 = "JUMPING JACKS", T1 = "0:30" },
                new WorkoutService { W1 = "SQUATS", T1 = "12x" },
                new WorkoutService { W1 = "SQUATS", T1 = "12x" },
                new WorkoutService { W1 = "SQUATS", T1 = "12x" },
                new WorkoutService { W1 = "FIRE HYDRANT LEFT", T1 = "12x" },
                new WorkoutService { W1 = "FIRE HYDRANT RIGHT", T1 = "12x" },
                new WorkoutService { W1 = "FIRE HYDRANT LEFT", T1 = "12x" },
                new WorkoutService { W1 = "FIRE HYDRANT RIGHT", T1 = "12x" },
                new WorkoutService { W1 = "FIRE HYDRANT LEFT", T1 = "12x" },
                new WorkoutService { W1 = "FIRE HYDRANT RIGHT", T1 = "12x" },
                new WorkoutService { W1 = "LUNGES", T1 = "14x" },
                new WorkoutService { W1 = "LUNGES", T1 = "14x" },
                new WorkoutService { W1 = "SIDE LEG CIRCLES LEFT", T1 = "12x" },
                new WorkoutService { W1 = "SIDE LEG CIRCLES RIGHT", T1 = "12x" },
                new WorkoutService { W1 = "SIDE LEG CIRCLES LEFT", T1 = "12x" },
                new WorkoutService { W1 = "SIDE LEG CIRCLES RIGHT", T1 = "14x" },
                new WorkoutService { W1 = "SUMO SQUATS", T1 = "12x" },
                new WorkoutService { W1 = "SUMO SQUATS", T1 = "12x" },
                new WorkoutService { W1 = "SUMO SQUATS", T1 = "12x" },
                new WorkoutService { W1 = "REVERSE FLUTTER KICKS", T1 = "12x" },
                new WorkoutService { W1 = "REVERSE FLUTTER KICKS", T1 = "12x" },
                new WorkoutService { W1 = "REVERSE FLUTTER KICKS", T1 = "12x" },
                new WorkoutService { W1 = "WALL SIT", T1 = "00:30" },
                new WorkoutService { W1 = "LEFT QUAD STRETCH WITH WALL", T1 = "00:30" },
                new WorkoutService { W1 = "RIGHT QUAD STRETCH WITH WALL ", T1 = "00:30" },
                new WorkoutService { W1 = "KNEE TO CHEST STRETCH LEFT", T1 = "00:30" },
                new WorkoutService { W1 = "KNEE TO CHEST STRETCH RIGHT", T1 = "00:30" },
                new WorkoutService { W1 = "SINGLE LEG CALF HOP LEFT", T1 = "12x" },
                new WorkoutService { W1 = "SINGLE LEG CALF HOP RIGHT", T1 = "12x" },
                new WorkoutService { W1 = "SINGLE LEG CALF HOP LEFT", T1 = "12x" },
                new WorkoutService { W1 = "SINGLE LEG CALF HOP RIGHT", T1 = "12x" },
                new WorkoutService { W1 = "SINGLE LEG CALF HOP LEFT", T1 = "12x" },
                new WorkoutService { W1 = "SINGLE LEG CALF HOP RIGHT", T1 = "12x" },
                new WorkoutService { W1 = "CALF STRETCH LEFT", T1 = "00:30" },
                new WorkoutService { W1 = "CALF STRETCH RIGHT", T1 = "00:30" },
            };
            await Application.Current.MainPage.Navigation.PushAsync(new WorkoutsPlanView());
        }

        async Task AdvancedLegs()
        {
            App.ListOfWorkouts = new ObservableCollection<WorkoutService> {
                new WorkoutService { W1 = "BURPEES", T1 = "10x" },
                new WorkoutService { W1 = "SQUATS", T1 = "14x" },
                new WorkoutService { W1 = "SQUATS", T1 = "14x" },
                new WorkoutService { W1 = "SQUATS", T1 = "14x" },
                new WorkoutService { W1 = "BOTTON LEGF LIFT LEFT", T1 = "12" },
                new WorkoutService { W1 = "BOTTON LEGF LIFT RIGHT ", T1 = "12x" },
                new WorkoutService { W1 = "BOTTON LEGF LIFT LEFT", T1 = "12" },
                new WorkoutService { W1 = "BOTTON LEGF LIFT RIGHT ", T1 = "12x" },
                new WorkoutService { W1 = "BOTTON LEGF LIFT LEFT", T1 = "12" },
                new WorkoutService { W1 = "BOTTON LEGF LIFT RIGHT ", T1 = "12x" },
                new WorkoutService { W1 = "CURTSY LUNGES", T1 = "14x" },
                new WorkoutService { W1 = "CURTSY LUNGES", T1 = "14x" },
                new WorkoutService { W1 = "CURTSY LUNGES", T1 = "14x" },
                new WorkoutService { W1 = "SIDE LEG CIRCLES RIGHT", T1 = "12x" },
                new WorkoutService { W1 = "SIDE LEG CIRCLES LEFT", T1 = "12x" },
                new WorkoutService { W1 = "SIDE LEG CIRCLES RIGHT", T1 = "12x" },
                new WorkoutService { W1 = "SIDE LEG CIRCLES LEFT", T1 = "12x" },
                new WorkoutService { W1 = "SIDE LEG CIRCLES RIGHT", T1 = "12x" },
                new WorkoutService { W1 = "SIDE LEG CIRCLES LEFT", T1 = "12x" },
                new WorkoutService { W1 = "JUMPING SQUATS ", T1 = "14x" },
                new WorkoutService { W1 = "JUMPING SQUATS ", T1 = "14x" },
                new WorkoutService { W1 = "JUMPING SQUATS ", T1 = "14x" },
                new WorkoutService { W1 = "GLUTE KICK BACK LEFT", T1 = "16x" },
                new WorkoutService { W1 = "GLUTE KICK BACK RIGHT", T1 = "16x" },
                new WorkoutService { W1 = "GLUTE KICK BACK LEFT", T1 = "16x" },
                new WorkoutService { W1 = "GLUTE KICK BACK RIGHT", T1 = "16x" },
                new WorkoutService { W1 = "GLUTE KICK BACK LEFT", T1 = "16x" },
                new WorkoutService { W1 = "GLUTE KICK BACK RIGHT", T1 = "16x" },
                new WorkoutService { W1 = "WALL SIT", T1 = "00:30" },
                new WorkoutService { W1 = "LEFT QUAD STRETCH WITH WALL", T1 = "00:30" },
                new WorkoutService { W1 = "RIGHT QUAD STRETCH WITH WALL", T1 = "00:30" },
                new WorkoutService { W1 = "LYING BUTTERFLY STRETCH", T1 = "00:30" },
                new WorkoutService { W1 = "LEANING STRETCHER RAISES", T1 = "16x" },
                new WorkoutService { W1 = "LEANING STRETCHER RAISES", T1 = "16x" },
                new WorkoutService { W1 = "LEANING STRETCHER RAISES", T1 = "16x" },
                new WorkoutService { W1 = "WALL RESISTING SINGLE LEG CALF RAISE RIGHT", T1 = "16x" },
                new WorkoutService { W1 = "WALL RESISTING SINGLE LEG CALF RAISE RIGHT", T1 = "16x" },
                new WorkoutService { W1 = "WALL RESISTING SINGLE LEG CALF RAISE LEFT", T1 = "16x" },
                new WorkoutService { W1 = "WALL RESISTING SINGLE LEG CALF RAISE RIGHT", T1 = "16x" },
                new WorkoutService { W1 = "CALF STRETCH LEFT", T1 = "00:30" },
                new WorkoutService { W1 = "CALF STRETCH RIGHT", T1 = "00:30" },
            };
            await Application.Current.MainPage.Navigation.PushAsync(new WorkoutsPlanView());
        }

        //SHOULDERSANDBACK
        async Task BeginnerShoulderAndBack()
        {
            App.ListOfWorkouts = new ObservableCollection<WorkoutService> {
                new WorkoutService { W1 = "JUMPING JACKS", T1 = "0:30" },
                new WorkoutService { W1 = "ARM RAISES", T1 = "0:30" },
                new WorkoutService { W1 = "RHOMBOID PULLS", T1 = "x14" },
                new WorkoutService { W1 = "SIDE ARM RAISE", T1 = "0:30" },
                new WorkoutService { W1 = "KNEE PUSH-UPS", T1 = "x14" },
                new WorkoutService { W1 = "SIDE-LYING FLOOR STRETCH LEFT", T1 = "0:30" },
                new WorkoutService { W1 = "SIDE-LYING FLOOR STRETCH RIGHT", T1 = "0:30" },
                new WorkoutService { W1 = "ARM SCISSORS", T1 = "0:30" },
                new WorkoutService { W1 = "RHOMBOID PULLS", T1 = "x12" },
                new WorkoutService { W1 = "SIDE ARM RAISES", T1 = "0:30" },
                new WorkoutService { W1 = "KNEE PUSH-UPS", T1 = "x14" },
                new WorkoutService { W1 = "PRONE TRICEPS PUSH UPS", T1 = "x14" },
                new WorkoutService { W1 = "RECLINED RHOMBOID SQUEEZES", T1 = "x12" },
                new WorkoutService { W1 = "PRONE TRICEPS PUSH UPS", T1 = "x14" },
                new WorkoutService { W1 = "RECLINED RHOMBOID SQUEEZES", T1 = "x12" },
                new WorkoutService { W1 = "CHILD´S POSE", T1 = "0:30" },
            };
            await Application.Current.MainPage.Navigation.PushAsync(new WorkoutsPlanView());
        }

        async Task IntermediateShoulderAndBack()
        {
            App.ListOfWorkouts = new ObservableCollection<WorkoutService> {
                new WorkoutService { W1 = "JUMPING JACKS", T1 = "0:30" },
                new WorkoutService { W1 = "TRICEPS KICKBACKS", T1 = "x14" },
                new WorkoutService { W1 = "INCLINE PUSH-UPS", T1 = "x14" },
                new WorkoutService { W1 = "RHOMBOID PULLS ", T1 = "x12" },
                new WorkoutService { W1 = "FLOOR TRICEP DIPS ", T1 = "x16" },
                new WorkoutService { W1 = "CAT COW POSE ", T1 = "0:30" },
                new WorkoutService { W1 = "TRICEPS KICKBACKS ", T1 = "x12" },
                new WorkoutService { W1 = "INCLINE PUSH-UPS ", T1 = "x12" },
                new WorkoutService { W1 = "HIP HINGE ", T1 = "x10" },
                new WorkoutService { W1 = "FLOOR TRICEP DIPS ", T1 = "x14" },
                new WorkoutService { W1 = "SIDE-LYING FLOOR STRETCH LEFT", T1 = "0:30" },
                new WorkoutService { W1 = "SIDE-LYING FLOOR STRETCH RIGHT", T1 = "0:30" },
                new WorkoutService { W1 = "HOVER PUSH UP", T1 = "x14" },
                new WorkoutService { W1 = "SWIMMER AND SUPERMAN", T1 = "x14" },
                new WorkoutService { W1 = "HOVER PUSH UP", T1 = "x14" },
                new WorkoutService { W1 = "SWIMMER AND SUPERMAN", T1 = "x14" },
                new WorkoutService { W1 = "CHILD´S POSE ", T1 = "0:30" },
            };
            await Application.Current.MainPage.Navigation.PushAsync(new WorkoutsPlanView());
        }

        async Task AdvancedShoulderAndBack()
        {
            App.ListOfWorkouts = new ObservableCollection<WorkoutService> {
                new WorkoutService { W1 = "JUMPING JACKS", T1 = "0:30" },
                new WorkoutService { W1 = "HYPEREXTENSION", T1 = "x14" },
                new WorkoutService { W1 = "PIKE PUSH UPS", T1 = "x14" },
                new WorkoutService { W1 = "REVERSE PUSH-UPS", T1 = "x12" },
                new WorkoutService { W1 = "INCHWORMS", T1 = "x16" },
                new WorkoutService { W1 = "SIDE-LYING FLOOR STRETCH LEFT", T1 = "0:30" },
                new WorkoutService { W1 = "SIDE-LYING FLOOR STRETCH RIGHT", T1 = "0:30" },
                new WorkoutService { W1 = "HYPEREXTENSION", T1 = "x12" },
                new WorkoutService { W1 = "PIKE PUSH UPS", T1 = "x12" },
                new WorkoutService { W1 = "REVERSE PUSH-UPS", T1 = "x10" },
                new WorkoutService { W1 = "INCHWORMS", T1 = "x14" },
                new WorkoutService { W1 = "CAT COW POSE", T1 = "00:30" },
                new WorkoutService { W1 = "SUPINE PUSH UP", T1 = "x14" },
                new WorkoutService { W1 = "FLOOR Y RAISES", T1 = "0:14" },
                new WorkoutService { W1 = "SUPINE PUSH UP", T1 = "x14" },
                new WorkoutService { W1 = "REVERSE SNOW ANGELS", T1 = "x12" },
                new WorkoutService { W1 = "CHILD´S POSE", T1 = "0:30" },
            };
            await Application.Current.MainPage.Navigation.PushAsync(new WorkoutsPlanView());
        }

    }
}