using Module05_Exercise01.ViewModel;

namespace Module05_Exercise01.View;

public partial class ViewEmployee : ContentPage
{
	public ViewEmployee()
	{
		InitializeComponent();
        var EmployeeViewModel = new EmployeeViewModel();
        BindingContext = EmployeeViewModel;
    }
}