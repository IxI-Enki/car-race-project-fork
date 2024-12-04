﻿namespace CarProject.Logic;

public class Section
{
  #region properties
  public int MaxSpeed { get; set; }
  
  public int Length { get; set; }
  
  public Section? NextSection { get; private set; }

  public Section? PreviousSection { get; private set; }
  #endregion

  #region constructor
  public Section(int speed , int length)
  {
    MaxSpeed = speed;
    Length = length;
  }
  #endregion

  #region public methods
  public void AddAfterMe(Section section)
  {
    Section? tmp = NextSection;

    NextSection = section;

    section.NextSection = tmp;
    section.PreviousSection = this;
  }

  public void AddBeforeMe(Section section)
  {
    Section? tmp = PreviousSection;
    
    PreviousSection = section;
    section.PreviousSection = tmp;
    
    if (tmp != null)
      tmp.NextSection = section;

    section.NextSection = this;
  }
  #endregion

}