using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Configuration;
using System.Security.Policy;
using System.Text;
using WPFAndMVVM2.Models;

namespace WPFAndMVVM2.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private PersonRepository personRepo = new PersonRepository();

        public event PropertyChangedEventHandler PropertyChanged;
        // Implement the rest of this MainViewModel class below to 
        // establish the foundation for data binding !
        public ObservableCollection<PersonViewModel> PersonsVM {  get; set; } 

        public MainViewModel()
        {
            PersonsVM = new ObservableCollection<PersonViewModel>(); //ObservableCollection kan se hvis man tilføjer noget til sin Collection
            foreach (Person person in personRepo.GetAll())           //List kan ikke se hvis man tilføjer noget nyt til sin liste
            {
                PersonViewModel personViewModel = new PersonViewModel(person);
                PersonsVM.Add(personViewModel);
            } 
            
        }

        private PersonViewModel selectedPerson;

        public PersonViewModel SelectedPerson
        {
            get { return selectedPerson; }
            set 
            { 
                selectedPerson = value;
                OnPropertyChanged("SelectedPerson");
            }
        }
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public void AddDefaultPerson()
        {
            Person person = personRepo.Add("Specify FirstName", "Specify LastName", 0, "Specify Phone");
            PersonViewModel personViewModel = new PersonViewModel(person);
            PersonsVM.Add(personViewModel);
            SelectedPerson = personViewModel;
        }
        public void DeleteSelectedPerson() 
        {
            selectedPerson.DeletePerson(personRepo);
            PersonsVM.Remove(SelectedPerson);
        }
    }
}
