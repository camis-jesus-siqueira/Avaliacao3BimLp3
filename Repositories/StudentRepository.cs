StudentRepository
{
// insere um estudante na tabela 
public Student save (Student student);
// deleta um estudante da tabela
public void Delete (string id);
//marca um estudante como formado
public void MarkAsFormed (string id);
//retorna todos os estudantes
public list<Student> GetAll();
//estudantes formados
public list<Student> GetAllFormed();
//Retorna todos os estudantes de uma cidade, deve ser possivel nome incompleto da city ="sao"
public list<Student> GetAllStudentByCity(string city);
//estudantes presentes na cidade
public list<Student> GetAllByCities(string cities);
// agrupados por cidade
public list<CountStudentGroupByAttribute> CountByCittes() ;
// agrupados por formados e nao formados
public list<CountStudentGroupByAttribute> CountByFormed() ;

}