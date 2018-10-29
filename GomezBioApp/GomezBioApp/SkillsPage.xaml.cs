using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GomezBioApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SkillsPage : ContentPage
	{
        public ObservableCollection<Skill> Skills { get; set; }
		public SkillsPage ()
		{
			InitializeComponent ();
            this.Skills = new ObservableCollection<Skill>();
            this.Skills.Add(new Skill {Icon = "javaIcon.png", Description = "Java Programming Basics", Name = "Java" });
            this.Skills.Add(new Skill {Icon = "xamrinIcon.png", Description = "Xamarin Forms Basics", Name = "Xamarin Forms" });
            this.Skills.Add(new Skill {Icon = "carIcon.png", Description = "8 years driving experience", Name = "Driving Experience" });
            skillsListView.ItemsSource = this.Skills;
		}

        public class Skill
        {
            public string Icon { get; set; }
            public string Description { get; set; }
            public string Name { get; set; }
        }
    }
}