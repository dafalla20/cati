using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pcda.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Add : ContentPage
    {
        public Add()
        {
            InitializeComponent();
            Go();
        }

        public async void Go()
        {
            await  image1.RelRotateTo(360, 500);
            await image2.RelRotateTo(360, 500);
            await image3.RelRotateTo(360, 500);
            await image4.RelRotateTo(360, 500);
            uint duration = 120 * 80 * 1000;
            await Task.WhenAll(
              //Logd.RotateTo(307 * 360, duration),
              Logd.RotateXTo(251 * 360, duration),
              Logd.RotateYTo(251 * 360, duration)
            );

        }


        private void BTN0_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (NID.Text.Length == 10)
                {

                    Slide0.SetValue(IsVisibleProperty, false);
                    Slide1.SetValue(IsVisibleProperty, true);
                    Nav.SetValue(IsVisibleProperty, true);
                    IDLBL.Text = NID.Text;
                }
                else
                {
                    _ = DisplayAlert("خطأ", "الرقم الوطني غير صحيح ! ", "OK"); 
                }
            }
            catch (Exception)
            {

                _ = DisplayAlert("خطأ", "جميع الحقول مطلوبة ! ", "OK");
            }
        }

        private void GenderSwitchFeMale_OnChanged(object sender, ToggledEventArgs e)
        {
            if (GenderSwitchFeMale.On == true)
            { 
                GenderSwitchMale.On = false;
                GenderLBL.Text = " الجنس :  أنثي";
                Wifes.SetValue(IsVisibleProperty, false);

            }
            else
            {
            }
        }

        private void GenderSwitchMale_OnChanged(object sender, ToggledEventArgs e)
        {
            if (GenderSwitchMale.On == true)
            { 
                GenderSwitchFeMale.On = false;
                GenderLBL.Text = " الجنس :  ذكر";
            }
          
        }

        private void MaritalSwitchyes_OnChanged(object sender, ToggledEventArgs e)
        {
            if (MaritalSwitchyes.On == true)
            {
                MaritalSwitchNo.On = false;
             chiled.SetValue(IsVisibleProperty, true);
                Wifes.SetValue(IsVisibleProperty, true);
                MarLBL.Text = "الحالة الإجتماعية : متزوج";
                if (GenderSwitchFeMale.On == true)
                {
                    Wifes.SetValue(IsVisibleProperty, false);
                }

            }
            else
            {
                chiled.SetValue(IsVisibleProperty, false);

                
            }
        }

        private void MaritalSwitchNo_OnChanged(object sender, ToggledEventArgs e)
        {
            if (MaritalSwitchNo.On == true)
            {
                MaritalSwitchyes.On = false;
                chiled.SetValue(IsVisibleProperty, false);
                MarLBL.Text = "الحالة الإجتماعية : أعزب";

            }
        }

        private void BackBTN_Clicked(object sender, EventArgs e)
        {

           try {
                if (Slide1.IsVisible == IsVisible)
                {

                    Slide1.SetValue(IsVisibleProperty, false);
                    Slide0.SetValue(IsVisibleProperty, true);
                    Nav.SetValue(IsVisibleProperty, false);

                }
                else
                {
                    if (Slide2.IsVisible == IsVisible)
                    {

                        Slide2.SetValue(IsVisibleProperty, false);
                        Slide1.SetValue(IsVisibleProperty, true);
                    }
                    else
                    {
                        if (Slide3.IsVisible == IsVisible)
                        {

                            Slide3.SetValue(IsVisibleProperty, false);
                            Slide2.SetValue(IsVisibleProperty, true);
                        }
                    }
                 

                }
            }
            catch (Exception)
            {

                _ = DisplayAlert("خطأ", "جميع الحقول مطلوبة ! ", "OK");
            }
        }

        private void NextBTN_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (Slide1.IsVisible == IsVisible)
                {

                    Slide1.SetValue(IsVisibleProperty, false);
                    Slide2.SetValue(IsVisibleProperty, true);
                }
                else
                {
                    if (Slide2.IsVisible == IsVisible)
                    {

                        Slide2.SetValue(IsVisibleProperty, false);
                        Slide3.SetValue(IsVisibleProperty, true);
                        NationalIdLBL.Text = "الرقم الوطني : " + NID.Text; 
                        NameLBL.Text = "الاسم : " + Name.Text;
                        AgeLBL.Text = "العمر : " + Age.SelectedItem;
                        PhoneLBL.Text = "  رقم الهاتف : " + Phone.Text;
                        EduLBL.Text = " المستوى التعليمي : " + Edu.SelectedItem;
                        JobLBL.Text = " المهنة : " + Job.Text;
                        CityLBL.Text = " القرية : " + City.SelectedItem;
                    }


                }
            }
            catch (Exception)
            {

                _ = DisplayAlert("خطأ", "جميع الحقول مطلوبة ! ", "OK");
            }
        }

        private async void RecordBTN_Clicked(object sender, EventArgs e)
        {

            await image1.RelRotateTo(360, 1000);
            Slidea.SetValue(IsVisibleProperty, false);
            Slide0.SetValue(IsVisibleProperty, true);

        }

        
     

        private async void RecordBTN2_Clicked(object sender, EventArgs e)
        {
            uint duration = 20 * 80 * 1000;

            await Task.WhenAll(
              image1.RotateTo(307 * 360, duration),
              image1.RotateXTo(251 * 360, duration),
              image1.RotateYTo(199 * 360, duration)
            );
      
        }
    }
}