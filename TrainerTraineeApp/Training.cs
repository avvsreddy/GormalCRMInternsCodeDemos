namespace TrainerTraineeApp
{
    class Training
    {
        public Trainer Trainer { get; set; }
        public List<Trainee> Trainees { get; set; } = new List<Trainee>();

        public Course Course { get; set; }

        public int GetNumberOfTrainees()
        {
            return Trainees.Count;
        }

        public string GetTrainingOrgName()
        {
            return Trainer.Organization.Name;
        }

        public int GetTrainingDurationInHrs()
        {
            int duration = 0;
            // for each module
            foreach (Module module in Course.Modules)
            {
                // for each unit
                foreach (Unit unit in module.Units)
                {
                    duration += unit.Duration;
                }
            }
            return duration;
        }
    }
}
