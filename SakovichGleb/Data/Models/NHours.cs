namespace SakovichGleb.Data.Models
{
    public class NHours
    {
        public int Id { set; get; }
        public int IdMonth { set; get; } // id месяца
        public ushort Lectures { set; get; }// лекции
        public ushort PracticesLessons { set; get; } // практики
        public ushort Labs { set; get; } // лабораторные
        public ushort KursWork { set; get; } //курсовое проектированние
        public ushort RGR { set; get; } // РГР
        public ushort TestWork { set; get; } // контрольные работы
        public ushort Offsets { set; get; } // Зачёты
        public ushort Consaltings { set; get; } // Консультации
        public float Exams { set; get; } // экзамены
        public ushort Practics { set; get; } // Практики (учебная и производственная)
        public ushort GuidanceDiplomaDesign { set; get; } // Руководство дипломным проектированием
        public ushort ConsaltingDiplomaDesign { set; get; } // Консультации дипломного проектирования
        public ushort ReviewDiplomaDesign { set; get; } // Рецензия дипломного проектирования
        public float GEK { set; get; } // ГЭК
        public ushort Mag { set; get; } // Руководство магистрантами
        public ushort GuidancePost { set; get; } // Руководство аспирантами
        public string Noil { set; get; } // Примечание
        public float AllTime { set; get; }  // Всего

        public NHours()
        {
            Lectures = 0; PracticesLessons = 0;
            Labs = 0; KursWork = 0;
            Consaltings = 0; Offsets = 0;
            Exams = 0; GuidancePost = 0;
            GuidanceDiplomaDesign = 0; ConsaltingDiplomaDesign = 0;
            ReviewDiplomaDesign = 0; GEK = 0;
            Practics = 0; Mag = 0;
            TestWork = 0; AllTime = 0;
        }

        public NHours(
            ushort lectures = 0, ushort practicesLessons = 0,
            ushort labs = 0, ushort kursWork = 0,
            ushort consaltings = 0, ushort offsets = 0,
            float exams = 0f, ushort guidancePost = 0,
            ushort guidanceDiplomaDesign = 0, ushort consaltingDiplomaDesign = 0,
            ushort reviewDiplomaDesign = 0, float gek = 0f,
            ushort practics = 0, ushort mag = 0,
            ushort testWork = 0)
        {
            Lectures = lectures; PracticesLessons = practicesLessons;
            Labs = labs; KursWork = kursWork;
            Consaltings = consaltings; Offsets = offsets;
            Exams = exams; GuidancePost = guidancePost;
            GuidanceDiplomaDesign = guidanceDiplomaDesign; ConsaltingDiplomaDesign = consaltingDiplomaDesign;
            ReviewDiplomaDesign = reviewDiplomaDesign; GEK = gek;
            Practics = practics; Mag = mag;
            TestWork = testWork;
            AllTime = lectures + practicesLessons + labs + kursWork + consaltings + offsets
                + exams + guidancePost + guidanceDiplomaDesign + consaltingDiplomaDesign + reviewDiplomaDesign
                + gek + practics + mag + testWork;
        }
    }
}
