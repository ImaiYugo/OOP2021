using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SampleUnitConverter
{
    class MainWindowViewModel: ViewModel
    {
        private double metricValue;
        private double imperialValue;

        //▲ボタンで呼ばれるコマンド【ヤード単位からメートル単位】
        public ICommand imperialUnitToMetric { get; private set; }
        //▼ボタンで呼ばれるコマンド【メートル単位からヤード単位】
        public ICommand MetricToImperaiUnit { get; private set; }

        //上のComboBoxで選択されている値
        public MetricUnit CurrentMetricUnit { get; set; }

        //下のComboBoxで選択されている値
        public ImperialUnit CurrentImperialcUnit { get; set; }

        public double MetricValue
        {
            get { return this.metricValue; }
            set { 
                this.metricValue = value;
                this.OnPropertyChanged();   //Viewへ通知
            }
        }

        public double ImperialValue
        {
            get { return this.imperialValue; }
            set {
                this.imperialValue = value;
                this.OnPropertyChanged();   //Viewへ通知
            }
        }

        //コンストラクタ
        public MainWindowViewModel() {
            this.CurrentMetricUnit = MetricUnit.Units.First();      //メートル単位
            this.CurrentImperialcUnit = ImperialUnit.Units.First(); //ヤード単位

            this.MetricToImperaiUnit = new DelegateCommand(
                () => this.ImperialValue = this.CurrentImperialcUnit.FromMetricUnit(
                    this.CurrentMetricUnit,this.MetricValue));
            this.imperialUnitToMetric = new DelegateCommand(
                () => this.MetricValue = this.CurrentMetricUnit.FromImperialUnit(
                    this.CurrentImperialcUnit, this.ImperialValue));

        }
    }
}
