using Maui.UnitTestError;
using Maui.UnitTestError.ViewModel;

namespace Maui.UnitTests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        MainPageViewModel viewModel = new MainPageViewModel();
        
        Assert.NotNull(viewModel);
        Assert.Equal("123456", viewModel.Name);
    }
}