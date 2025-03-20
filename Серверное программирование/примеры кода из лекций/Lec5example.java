// Лекция 5. ORM - Связи и запросы
//@OneToOne
@Entity
public class Person {
@OneToOne(optional = false, cascade = CascadeType.ALL)
@JoinColumn(name = "PASSPORT_ID")
private Passport passport;
}
@Entity
public class Passport {
@OneToOne(optional = false, mappedBy = "passport")
private Person owner;
}
//@OneToMany/ @ManyToOne

@Entity
public class Person {
@ManyToOne(optional = false, cascade = CascadeType.ALL)
@JoinColumn(name = "ADDRESS_ID")
private Address primaryAddress;
}
@Entity
public class Address {
@OneToMany(mappedBy = "primaryAddress", fetch = FetchType.EAGER)
private Collection<Person> tenants;
}

//@ManyToMany
@Entity
public class Person {
@ManyToMany(fetch = FetchType.LAZY, cascade = CascadeType.ALL)
@JoinTable(name = "PERSON_COMPANIES",
	joinColumns = @JoinColumn(name = "PERSON_ID"),
	inverseJoinColumns = @JoinColumn(name = "COMPANY_ID")
)
private Collection<Company> workingPlaces;
}
@Entity
public class Company {
@ManyToMany(mappedBy = "workingPlaces")
private Collection<Person> workers;
}


// Criteria
// Чтение данных
Criteria criteria = session.CreateCriteria(Developer.class);
criteria.setFirstResult(5);
criteria.setMaxResult(10);
List<Developer> developers = criteria.list();

//Сортировка данных
Criteria criteria = session.createCriteria(Develpoer.class).addOrder(order.asc("firstName"));
criteria.addOrder(order.desc("firstName"));
//Ограничение данных
Criteria criteria = session.createCriteria(Developer.class) 
	.add(Restrictions.ge("experience", 3); 

Criteria criteria = session.createCriteria(Developer.class) 
	.add(Restrictions.like("login", "serg%");

Criteria criteria = session.createCriteria(Developer.class) 
	.add(Restrictions.isNull("birth_date"); 

Criteria criteria = session.createCriteria(Developer.class) 
	.add(Restrictions.isNotNull("birth_date"); 
	
//Сочетание ограничений
session.createCriteria(Person.class)
  .add(Restrictions.or(
    	Restrictions.like("lastName", "Te%"),
    	Restrictions.eq("firstName", "John")
  ))
  .list()
  
//JPA Criteria
EntityManager em = entityManagerFactory.createEntityManager();
em.getTransaction().begin();
CriteriaBuilder cb = em.getCriteriaBuilder();

CriteriaQuery<Person> personCriteria = cb.createQuery(Person.class);
Root<Person> personRoot = personCriteria.from(Person.class);
personCriteria.select(personRoot);
em.createQuery(personCriteria)
  .getResultList()
  .forEach(System.out::println);
  
  //JPA Criteria - использование разных классов
  CriteriaQuery<Passport> passportCriteria = cb.createQuery(Passport.class);
Root<Person> personPassportRoot = passportCriteria.from(Person.class);
passportCriteria.select(personPassportRoot.get("passport"));
em.createQuery(passportCriteria)
  .getResultList()
  .forEach(System.out::println);
  
 //JPA Criteria - использование ограничений
 CriteriaQuery<Passport> passportOwnCriteria = cb.createQuery(Passport.class);
Root<Passport> ownerPassportRoot = passportOwnCriteria.from(Passport.class);
passportOwnCriteria.select(ownerPassportRoot);
passportOwnCriteria.where(
	cb.equal(
		ownerPassportRoot.get("owner").get("lastName"), 
		"Testoff")
);
em.createQuery(passportOwnCriteria)
  .getResultList()
  .forEach(System.out::println);
  
 //JPA Criteria - связанные сущности
CriteriaQuery<Person> personWorkCriteria = cb.createQuery(Person.class);
Root<Person> personWorkRoot = personWorkCriteria.from(Person.class);
Join<Person, Company> company = personWorkRoot.join("workingPlaces");
personWorkCriteria.select(personWorkRoot);
personWorkCriteria.where(cb.equal(company.get("name"), "Acme Ltd"));
em.createQuery(personWorkCriteria)
  .getResultList()
  .forEach(System.out::println); 
  
 //Metamodel
 @StaticMetamodel(Company.class)
public abstract class Company_ extends AbstractIdentifiableObject_ {

	public static volatile SingularAttribute<Company, String> name;
	public static volatile CollectionAttribute<Company, Person> workers;

}

 //Metamodel - инструменты
<dependency>
  <groupId>org.hibernate</groupId>
  <artifactId>hibernate-jpamodelgen</artifactId>
  <version>${hibernate.version}</version>
  <scope>provided</scope>
</dependency>

