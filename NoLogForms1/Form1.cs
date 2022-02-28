using System;
using System.ComponentModel;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;
using NLogForms1.Classes;
using NLogForms1.Interfaces;

namespace NLogForms1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Closing += OnClosing;

            // setup NLogging
            LogConfiguration();
        }

        #region Logging configuration and private variables

        private ServiceProvider serviceProvider;
        private ILogger<Form1> _logger;

        private void LogConfiguration()
        {

            serviceProvider = new ServiceCollection()
                .AddSingleton<ICommonService, FooService>()
                .AddLogging(builder =>
                {
                    builder.SetMinimumLevel(LogLevel.Trace);
                    builder.AddNLog(new NLogProviderOptions
                    {
                        CaptureMessageTemplates = true,
                        CaptureMessageProperties = true
                    });
                })
                .BuildServiceProvider();


            _logger = serviceProvider.GetService<ILoggerFactory>().CreateLogger<Form1>();

            _logger.LogInformation("Starting application...");

        }

        #endregion

        private void ExecuteMethodButton_Click(object sender, EventArgs e)
        {
            var fooService = serviceProvider.GetService<ICommonService>();
            fooService.Execute();
        }

        private void WorkerMethodButton_Click(object sender, EventArgs e)
        {
            var fooService = serviceProvider.GetService<ICommonService>();
            fooService.Worker();
        }

        private void FinderButton_Click(object sender, EventArgs e)
        {
            var fileService = new FileServices(serviceProvider);
            fileService.FindFile();
        }

        private void OnClosing(object sender, CancelEventArgs e)
        {
            _logger.LogInformation("Exiting application...");
        }
    }
}
