interface ITraining
{
  string Id { get; }
  float Weight;
  string ApproachesNumber { get; }
  string RepeatsNumber { get; }

}


class RoundTraining : ITraining
{

}

class ClassicTraining
{

}