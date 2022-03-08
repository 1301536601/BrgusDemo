
// ReSharper disable All
/// <summary>
/// Student Modle
/// </summary>
public class Student
{
    /// <summary>
    /// Id
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Name
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Address
    /// </summary>
    public string  Address { get; set; }
    
    /// <summary>
    /// Age
    /// </summary>
    public int Age { get; set; }
    
    /// <summary>
    /// Email
    /// </summary>
    public string Email { get; set; }
}

/// <summary>
/// class Model
/// </summary>
public class ClassGrade
{
    /// <summary>
    /// ClassName
    /// </summary>
    public  string ClassName { get; set; }
    
    /// <summary>
    /// ClassIndex
    /// </summary>
    public string  ClassIndex { get; set; }
    
    /// <summary>
    /// 学生列表
    /// </summary>
    public List<Student> Students { get; set; }
}