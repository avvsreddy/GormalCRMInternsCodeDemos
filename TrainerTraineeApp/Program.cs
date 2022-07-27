using TrainerTraineeApp;

Organization org = new Organization();
org.Name = "GormalONE";

Trainer trainer = new Trainer();
trainer.Organization = org;

Trainee t1 = new Trainee();
Trainee t2 = new Trainee();
Trainee t3 = new Trainee();
Trainee t4 = new Trainee();
Trainee t5 = new Trainee();

trainer.Trainees.Add(t1);
trainer.Trainees.Add(t2);
trainer.Trainees.Add(t3);
trainer.Trainees.Add(t4);
trainer.Trainees.Add(t5);

Training training = new Training();
training.Trainer = trainer;
trainer.Trainings.Add(training);
training.Trainees.Add(t1);
training.Trainees.Add(t2);
training.Trainees.Add(t3);
training.Trainees.Add(t4);
training.Trainees.Add(t5);

Course course = new Course();
training.Course = course;

Module m1 = new Module();
Module m2 = new Module();
Module m3 = new Module();

course.Modules.Add(m1);
course.Modules.Add(m2);
course.Modules.Add(m3);

Unit u1 = new Unit();
u1.Duration = 60;
Unit u2 = new Unit { Duration = 30 };
Unit u3 = new Unit { Duration = 20 };
Unit u4 = new Unit { Duration = 30 };
Unit u5 = new Unit { Duration = 60 };
Unit u6 = new Unit { Duration = 30 };
Unit u7 = new Unit { Duration = 90 };
Unit u8 = new Unit { Duration = 30 };

m1.Units.Add(u1);
m1.Units.Add(u2);

m2.Units.Add(u3);
m2.Units.Add(u4);

m3.Units.Add(u5);
m3.Units.Add(u6);
m3.Units.Add(u7);
m3.Units.Add(u8);



Console.WriteLine($"No. of Tranees : {training.GetNumberOfTrainees()}");
Console.WriteLine($"Org Name: {training.GetTrainingOrgName()}");
Console.WriteLine($"Total duration (min): {training.GetTrainingDurationInHrs()}");