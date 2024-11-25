# 💻 Padrões de Projeto
Este repositório foi criado para o estudo dos **padrões de projeto do GoF (Gang of Four)** e é inspirado no excelente curso **Rabiscando Padrões de Projeto**. A implementação, no entanto, foi feita utilizando a linguagem de programação C#.

Este Guia terá a definição, aplicabilidade, componentes, diagrama original e diagrama da implementação adaptado para nosso contexto.

## 🛠️ Grupos de Padrões
Os Padrões são divididos em 3 grupos:
- **Criacionais:** Encapsulam a criação/instanciação de objetos, ajuda a tornar um sistema independente de como seus objetos são criados, compostos e representados.

- **Estruturais:** Definem como classes e objetos são compostos para formar estruturas maiores: são padrões de construção de fato, como estruturar as classes e objetos.

- **Comportamentais:** Definem algoritmos e atribuição de responsabilidade entre objetos, além de definir classes e objetos, também definem os padrões de comunicação entre eles. Foca de fato no comportamento de cada classe ou objeto em relação aos demais.

 ## 📦 Padrões Criacionais

 ### 1. Abstract Factory

- **Definição:** O padrão Abstract Factory fornece uma interface para criar famílias de objetos relacionados ou dependentes sem especificar suas classes concretas.

- **Contexto:** Simulação de um emissor de boletos com diferentes cálculos de juros, desconto e multa para dois bancos diferentes.

- **Aplicabilidade (Quando Utilizar):**
	- Quando um sistema deve ser independente de como seus produtos são criados, compostos ou representados.

	- Quando um sistema deve ser configurado com uma dentre múltiplas famílias de produtos.

	- Quando uma família de objetos relacionados foi projetada para ser usada em conjunto, e é necessário impor essa restrição.

	- Quando se deseja fornecer uma biblioteca de produtos e se deseja revelar para o cliente apenas suas interfaces, e não suas implementações.

- **Componentes:**
	- **AbstractFactory:** Declara uma interface a qual todas as fábricas concretas devem implementar, o que consiste em um conjunto de métodos para fabricar produtos concretos.

	- **FabricaConcreta:**
		- Implementam a interface declarada por AbstractFactory.
		- Criam as diferentes famílias de produtos.
		- Para criar um produto, o Cliente usa uma dessas fábricas concretas, então ele nunca precisa criar produtos concretos diretamente.

	- **ProdutoAbstrato:** Define a interface para um determinado tipo de produto.

	- **ProdutoConcreto:**
		- Implementa a interface ProdutoAbstrato.
		- São os integrantes de uma família de produtos.
		- É criado por uma FabricaConcreta.

	- **Cliente:** Usa apenas interfaces declaradas pelas classes AbstractFactory e ProdutoAbstrato, e é composta em tempo de execução por fábricas e produtos concretos.

- **Diagrama de Classe (Com Contexto):**

<div align="center">
  <img src="https://raw.githubusercontent.com/Willian-Brito/rabiscando-padroes-de-projeto/refs/heads/main/prints/Abstract%20Factory.png" alt="diagrama de classe com contexto" />
</div>

- **Diagrama de Classe (Sem Contexto):**

<div align="center">
  <img src="https://raw.githubusercontent.com/Willian-Brito/rabiscando-padroes-de-projeto/refs/heads/main/prints/Abstract%20Factory%20-%20original.png" alt="diagrama de classe sem contexto" />
</div>

### 2. Builder

- **Definição:** O padrão Builder separa a construção de um objeto complexo de sua representação de modo que o mesmo processo de construção de um objeto possa criar diferentes representações.

- **Contexto:** Criação de um Builder para uma classe que gera PDFs, onde tal classe possui muitos parâmetros em sua criação.

- **Aplicabilidade (Quando Utilizar):**
	- Quando o algoritmo que cria um objeto complexo deve ser independente das partes que o compõem e de como tais partes são montadas.
	
	- Quando o processo de construção deve diferentes para o objeto que é construído.

- **Componentes:**

	- **Builder:** Especifica uma interface abstrata para criação de partes de um objeto (produto), tal interface deverá ser seguida por todos os BuildersConcretos.

	- **BuilderConcreto:**
		- Constrói e monta partes do Produto utilizando a implementação concreta da interface Builder a qual implementa.

		- Define e mantém a representação (Produto) que cria.

	- **Diretor:** Constrói um objeto conforme suas necessidades. Para isso ele utiliza a interface de Builder.

	- **Produto:**

		- Representa o objeto complexo em construção. BuilderConcreto constrói a representação interna do produto e define o processo pelo qual ele é criado.

		- Produtos são os objetos resultantes. Produtos construídos por diferentes BuildersConcretos não precisam pertencer a mesma interface ou hierarquia de classes.

- **Diagrama de Classe (Com Contexto):**
<div align="center">
  <img src="https://raw.githubusercontent.com/Willian-Brito/rabiscando-padroes-de-projeto/refs/heads/main/prints/Builder.png" alt="diagrama de classe sem contexto" />
</div>

- **Diagrama de Classe (Sem Contexto):**
<div align="center">
  <img src="https://raw.githubusercontent.com/Willian-Brito/rabiscando-padroes-de-projeto/refs/heads/main/prints/Builder%20-%20original.png" alt="diagrama de classe sem contexto" />
</div>

### 3. Factory Method

- **Definição:** O Padrão Factory Method define uma interface para criar um objeto, mas permite que a subclasses possam decidir qual classe instanciar, possibilitando que uma classe seja capaz de prorrogar a instanciação de uma classe para subclasses.

- **Contexto:** Simulação de um emissor de boletos com diferentes cálculos de juros, desconto e multa para dois bancos diferentes. Tais boletos também possuem 3 diferente prazos de vencimentos pré-estipulados.

- **Aplicabilidade (Quando Utilizar):**
	- Quando uma classe não sabe antecipar qual tipo de objeto deve criar, ou seja, entre várias classes possíveis, não é possível prever qual delas deve ser utilizada.

	- Quando se precisa que uma classe delegue para suas subclasses especificação dos objetos que instanciam.

	- Quando classes delegam responsabilidade a uma dentre várias subclasses auxiliares, se deseja manter o conhecimento nelas e ainda saber qual subclasse foi utilizada em determinado contexto.


- **Componentes:**
	- **Produto:** Define a interface dos objetos que serão criados pelo método de factoryMethod() dos CriadoresConcretos.

	- **ProdutoConcreto:** Implementa a interface Produto. Isso permite que classes que usam os Produtos possam esperar a interface Produto ao invés de um ProdutoConcreto.

	- **Criador:** Declara o método fábrica (Factory Method) o qual retorna um objeto ProdutoConcreto. Também pode definir uma implementação padrão do factoryMethod, para o caso de uma subclasse o omitir. Tal implementação também precisa retornar um ProdutoConcreto. O Criador também é a classe que utiliza o ProdutoConcreto retornado pelo método factoryMethod.

	- **CriadorConcreto:** Implementa ou sobrescreve o factoryMethod(), para retornar uma instância de um ProdutoConcreto.

- **Diagrama de Classe (Com Contexto):**
<div align="center">
  <img src="https://raw.githubusercontent.com/Willian-Brito/rabiscando-padroes-de-projeto/refs/heads/main/prints/factory%20method.png" alt="diagrama de classe sem contexto" />
</div>

- **Diagrama de Classe (Sem Contexto):**
<div align="center">
  <img src="https://raw.githubusercontent.com/Willian-Brito/rabiscando-padroes-de-projeto/refs/heads/main/prints/factory%20method.png" alt="diagrama de classe sem contexto" />
</div>

### 4. Prototype

- **Definição:** O padrão Prototype especifica tipos de objetos a serem criados usando como base uma instância de outro objeto que serve como protótipo. Este padrão permite a clonagem de objetos existentes sem provocar dependência de suas classes.

- **Contexto:** Criação de protótipos de objetos semelhantes e de difícil criação que são muito requisitados no sistema de uma biblioteca virtual.

- **Aplicabilidade (Quando Utilizar):** O padrão Prototype pode ser utilizado quando um sistema deve ser independente de como seus produtos são criados, compostos e representados. este padrão também pode ser utilizado:

	- Quando as classes a serem instanciadas são especificadas em tempo de execução, por exemplo, por carregamento dinâmico.

	- Para evitar a construção de uma hierarquia de classes de fábricas que seja paralela à hierarquia de classes de produtos.

	- Quando instâncias de uma classe podem ter apenas algumas poucas combinações diferentes de estado. Pode ser mais conveniente criar um número correspondente de protótipos e cloná-los, em vez de instanciar as classes manualmente, cada vez com o estado apropriado.

- **Componentes:**
	- **Prototype:** Declara uma interface para clonar a si próprio.

	- **PrototypeConcreto:** Implementa uma operação para clonar a si próprio.

	- **Cliente:** Cria um novo objeto solicitando a um protótipo que clone a si próprio.

- **Diagrama de Classe (Com Contexto):**
<div align="center">
  <img src="https://raw.githubusercontent.com/Willian-Brito/rabiscando-padroes-de-projeto/refs/heads/main/prints/Prototype.png" alt="diagrama de classe sem contexto" />
</div>

- **Diagrama de Classe (Sem Contexto):**
<div align="center">
  <img src="https://raw.githubusercontent.com/Willian-Brito/rabiscando-padroes-de-projeto/refs/heads/main/prints/Prototype%20-%20original.png" alt="diagrama de classe sem contexto" />
</div>

### 5. Singleton

- **Definição:** O padrão Singleton garante que uma classe tenha **apenas uma instância** e fornece um **ponto global** de **acesso** a ela.

- **Contexto:** Criação de um único objeto de conexão a um banco de dados, evitando abertura de conexões desnecessárias.

- **Aplicabilidade (Quando Utilizar):**
	- Quando deve existir exatamente uma instância de uma classe e ela deve estar acessível aos clientes a partir de um ponto de acesso global
	conhecido.

- **Componentes:** Esse padrão é composto por apenas uma classe.
	- O atributo uniqueInstance contém a única instância de Singleton.

	- O método GetInstance() é estático, o que significa que é um método de classe, então pode ser acessado a partir de qualquer lugar do código utilizando Singleton.GetInstance();

- **Diagrama de Classe (Com Contexto):**
<div align="center">
  <img src="https://raw.githubusercontent.com/Willian-Brito/rabiscando-padroes-de-projeto/refs/heads/main/prints/Singleton.png" alt="diagrama de classe sem contexto" />
</div>

- **Diagrama de Classe (Sem Contexto):**
<div align="center">
  <img src="https://raw.githubusercontent.com/Willian-Brito/rabiscando-padroes-de-projeto/refs/heads/main/prints/Singleton%20-%20original.png" alt="diagrama de classe sem contexto" />
</div>

## ⚙️ Padrões Estruturais

### 6. Adapter

- **Definição:** O padrão Adapter converte a interface de uma classe para outra interface que o cliente esperar encontrar. O Adaptador permite que classes com interfaces incompatíveis trabalhem juntas.

- **Contexto:** Adaptação de interfaces de Gateway de pagamentos que antes eram incompatíveis com a interface que nosso sistema esperava.

- **Aplicabilidade (Quando Utilizar):**
	- Quando existe a necessidade de utilizar uma classe existente e sua interface é diferente da esperada.

	- Quando se deseja criar uma classe reutilizável que coopera com classes não relacionadas a ela ou que não foram previstas, ou seja, classes que não necessariamente têm interfaces compatíveis.

	- (Somente para adaptadores de objeto) Quando é necessário usar várias subclasses existentes, mas é impraticável adaptar sua interface sub-classificando cada uma delas. Um adaptador de objeto pode adaptar a interface de sua superclasse.

- **Componentes:**
	- **Cliente:** É a classe que espera a interface alvo.

	- **Alvo:** Interface esperada pelo Cliente. Deve ser implementada pelo Adapter.

	- **Adapter:** Converte a interface de Adaptado para a interface Alvo. Delega todas as solicitações para Adaptado.

	- **Adaptado:** Classe que possui interface incompatível com o cliente e por isso precisa ser adaptada.

- **Diagrama de Classe (Com Contexto):**
<div align="center">
  <img src="https://raw.githubusercontent.com/Willian-Brito/rabiscando-padroes-de-projeto/refs/heads/main/prints/Adapter.png" alt="diagrama de classe sem contexto" />
</div>

- **Diagrama de Classe (Sem Contexto):**
<div align="center">
  <img src="https://raw.githubusercontent.com/Willian-Brito/rabiscando-padroes-de-projeto/refs/heads/main/prints/Adapter%20-%20original.png" alt="diagrama de classe sem contexto" />
</div>

### 7. Bridge

- **Definição:** O Padrão Bridge desacopla uma abstração de sua implementação, ou seja, permite dividir uma classe grande ou um conjunto de classes diretamente ligadas em duas hierarquias separadas, deste modo as duas hierarquias podem variar de forma independente.

- **Contexto:** Remoção de classes desnecessárias para o envio de mensagens que partem de  emissores​ de tipos distintos. Tais mensagens podem ser enviadas por canais diferentes (e-mail e SMS).

- **Aplicabilidade (Quando Utilizar):**
	- Quando se deseja evitar uma ligação permanente entre uma abstração e sua implementação. Pode ser o caso, por exemplo, quando a implementação deve ser selecionada ou alternada no tempo de execução.

	- Quando tanto as abstrações quanto suas implementações devem ser extensíveis por subclassificação. Nesse caso, o padrão Bridge permite combinar as diferentes abstrações e implementações e estendê-las independentemente.

	- Quando mudanças na implementação de uma abstração não devem causar impacto nos clientes (o cliente não pode ser recompilado).

	- Quando existe uma proliferação de classes, como mostrado anteriormente no “Diagrama de classes de envio de mensagens por email e SMS”. Essa hierarquia de classes indica a necessidade de dividir um objeto em duas partes.

	- Quando se deseja compartilhar uma implementação entre vários objetos, e esse fato deve estar oculto no cliente.

- **Componentes:**
	- **Abstracao:** Define a interface da Abstração e mantém uma referência a um objeto do tipo Implementador.

	- **RedefinicaoDaAbstracao:** Estende a interface definida por Abstracao. É opcional.

	- **Implementador:** Define a interface para as classes de Implementador. Essa interface não precisa ser igual a interface Abstracao, na verdade, as duas interfaces podem ser bem diferentes. Normalmente, a interface do Implementador fornece apenas operações primitivas e a Abstracao define operações de nível superior com base nessas primitivas.

	- **ImplementadorConcreto:** Implementa a interface do Implementador e define sua implementação concreta.

- **Diagrama de Classe (Com Contexto):**
<div align="center">
  <img src="https://raw.githubusercontent.com/Willian-Brito/rabiscando-padroes-de-projeto/refs/heads/main/prints/Bridge.png" alt="diagrama de classe sem contexto" />
</div>

- **Diagrama de Classe (Sem Contexto):**
<div align="center">
  <img src="https://raw.githubusercontent.com/Willian-Brito/rabiscando-padroes-de-projeto/refs/heads/main/prints/Bridge%20-%20original.png" alt="diagrama de classe sem contexto" />
</div>

### 8. Composite

- **Definição:** ​O padrão Composite permite a composição de objetos em estruturas de árvore para representar hierarquias parte-todo. Com esse padrão, os clientes podem tratar objetos individuais ou composições de objetos de maneira transparente e uniforme.

- **Contexto:** Consulta, inclusão e remoção de arquivos em um sistema de diretórios que tem uma árvore como estrutura de dados. O diretório é organizado em pastas e sub-pastas.

- **Aplicabilidade (Quando Utilizar):**
	- Quando é necessário representar uma hierarquia parte-todo de objetos.

	- Quando é preciso que os clientes possam ignorar a diferença entre composições de objetos e objetos individuais, ou seja, os clientes devem tratar todos os objetos na estrutura composta de maneira uniforme.

- **Componentes:**
	
	- **Cliente:** O cliente utiliza a interface Componente para manipular os objetos da composição.

	- **Componente:** Define uma interface para todos os objetos da composição, o que inclui tanto os compostos quanto as folhas. Pode definir uma interface para acessar o pai de um componente na estrutura recursiva e a implementa, se apropriado.

	- **Folha:** Define o comportamento dos componentes primitivos, ou seja, que não possuem filhos. Isto é feito implementando as operações que o Componente aceita.

	- **Composite:** Também implementa as operações do Componente, o papel do composite é definir o comportamento dos componentes que possuem filhos. O Composite armazena seus filhos.

- **Diagrama de Classe (Com Contexto):**
<div align="center">
  <img src="https://raw.githubusercontent.com/Willian-Brito/rabiscando-padroes-de-projeto/refs/heads/main/prints/Composite.png" alt="diagrama de classe sem contexto" />
</div>

- **Diagrama de Classe (Sem Contexto):**
<div align="center">
  <img src="https://raw.githubusercontent.com/Willian-Brito/rabiscando-padroes-de-projeto/refs/heads/main/prints/Composite%20-%20original.png" alt="diagrama de classe sem contexto" />
</div>

### 9. Decorator

- **Definição:** O Padrão Decorator anexa responsabilidades adicionais a um objeto dinamicamente. Os Decorators fornecem uma alternativa flexível ao uso de subclasses para extensão de funcionalidades.

- **Contexto:** Cálculo de preço de pizzas no sistema de uma pizzaria onde existem diversos acréscimos de ingredientes para cada pizza.

- **Aplicabilidade (Quando Utilizar):**
	- Quando for necessário adicionar comportamentos a objetos individuais de forma dinâmica e transparente, sem afetar outros objetos.

	- Ao implementar comportamentos que podem ser fundamentais para determinados objetos e ao mesmo tempo desnecessários ou inapropriados a outros.

	- Quando um grande número de extensões produziria uma grande quantidade de subclasses para suportar todas as combinações de comportamentos possíveis. Ou quando uma definição de classe estiver oculta ou indisponível para subclassificação.

- **Componentes:**

	- **Component:** É o supertipo comum entre componenteConcreto e Decorator. Pode ser uma classe abstrata ou interface. Cada Component pode ser usado sozinho ou englobado por um decorator.
	
	- **ComponenteConcreto:** É o objeto ao qual novos comportamentos serão adicionados dinamicamente por meio dos Decorators. Ele estende Component.

	- **Decorator:** Cada decorator TEM-UM (engloba um) Component. Isso significa que todo Decorator deve manter uma referência a um Component. Os Decorators implementam a mesma interface ou classe abstrata que o componente que irão decorar.

	- **DecoratorConcreto:** Implementam a classe abstrata ou interface Decorator, graças ao polimorfismo também são do supertipo Component. Podem adicionar novos métodos ao componente que decoram, no entanto, novo comportamento geralmente é adicionado fazendo cálculos antes e/ou depois de um método existente no componente.

- **Diagrama de Classe (Com Contexto):**
<div align="center">
  <img src="https://raw.githubusercontent.com/Willian-Brito/rabiscando-padroes-de-projeto/refs/heads/main/prints/Decorator.png" alt="diagrama de classe sem contexto" />
</div>

- **Diagrama de Classe (Sem Contexto):**
<div align="center">
  <img src="https://raw.githubusercontent.com/Willian-Brito/rabiscando-padroes-de-projeto/refs/heads/main/prints/Decorator%20-%20original.png" alt="diagrama de classe sem contexto" />
</div>

### 10. Facade

- **Definição:** O padrão Facade fornece uma interface unificada para um conjunto de interfaces em um subsistema. O Facade define uma interface de nível mais alto que facilita a utilização do subsistema.

- **Contexto:** Simplificação da interface do sub-sistema de vendas de um e-commerce.

- **Aplicabilidade (Quando Utilizar):**
	- Quando é necessário fornecer uma interface simples para um subsistema complexo. Os subsistemas geralmente ficam mais complexos à medida que evoluem. A maioria dos padrões, quando aplicados, resulta em classes cada vez menores. Isso torna o subsistema mais reutilizável e fácil de personalizar, mas também se torna mais difícil de usar para clientes que não precisam personalizá-lo. Uma fachada pode fornecer uma visualização padrão simples do subsistema que é boa o suficiente para a maioria dos clientes. Somente clientes que precisam de mais personalizações precisam olhar além da fachada.

	- Quando existem muitas dependências entre clientes e as classes de implementação de uma abstração. Introduzir uma fachada para desacoplar o subsistema dos clientes e de outros subsistemas, promove a independência e a portabilidade do subsistema.

	- Quando se deseja estruturar subsistemas em camadas. Uma fachada define um ponto de entrada para cada nível do subsistema. Se os subsistemas
	são dependentes, será possível simplificar as dependências entre eles, fazendo-os se comunicar apenas através de suas fachadas.

- **Componentes:**

	- **Cliente:** É a classe que utiliza as facilidades oferecidas pela classe Facade.

	- **Facade:** Classe que fornece uma interface unificada e mais simples para o cliente. Ela Sabe quais classes de subsistema são responsáveis ​por uma solicitação feita pelo Cliente, delega tais solicitações aos objetos apropriados do subsistema.

	- **Subsistema mais complexo:** Possui as implementações das funcionalidades do subsistema. É o responsável por responder às solicitações feitas pela classe Facade. Não sabe que Facade existe.

- **Diagrama de Classe (Com Contexto):**
<div align="center">
  <img src="https://raw.githubusercontent.com/Willian-Brito/rabiscando-padroes-de-projeto/refs/heads/main/prints/Facade.png" alt="diagrama de classe sem contexto" />
</div>

- **Diagrama de Classe (Sem Contexto):**
<div align="center">
  <img src="https://raw.githubusercontent.com/Willian-Brito/rabiscando-padroes-de-projeto/refs/heads/main/prints/Facade%20-%20original.png" alt="diagrama de classe sem contexto" />
</div>

### 11. Flyweight

- **Definição:** ​​O padrão Flyweight permite usar compartilhamento para suportar grandes quantidades de objetos de granularidade fina.

- **Contexto:** Economia de armazenamento ao compartilhar informações comuns entre milhares de objetos "Árvore" em um software para criação de projetos de reflorestamento.

- **Aplicabilidade (Quando Utilizar):** A eficiência do padrão Flyweight depende muito de como e onde ele é aplicado. É recomendado que este padrão seja aplicado somente quando todas as condições abaixo forem verdadeiras:

	- Uma aplicação utiliza um grande número de objetos.
	- Os custos de armazenamento são altos por causa da grande quantidade de objetos.

	- Muitos objetos podem compartilhar uma mesma representação e é possível separar o estado extrínseco dos mesmos.

	- Muitos grupos de objetos podem ser substituídos por relativamente poucos objetos compartilhados, uma vez que seus estados extrínsecos são removidos.

	- A aplicação não depende da identidade dos objetos. Uma vez que objetos Flyweight podem ser compartilhados, testes de identidade produzirão o valor verdadeiro para objetos conceitualmente distintos.

- **Componentes:**

	- **Flyweight:** Declara uma interface através da qual Flyweights podem receber e atuar sobre estados extrínsecos.

	- **FlyweightConcreto:** Implementa a interface Flyweight e acrescenta armazenamento para estados intrínsecos, se houver. Um objeto FlyweightConcreto deve ser compartilhável. Qualquer estado que ele armazene deve ser intrínseco, ou seja, imutável e independente do contexto que o objeto FlyweightConcreto se encontra.

	- **FlyweightConcretoNaoCompartilhavel:** Nem todas as subclasses (caso existam) de Flyweight necessitam ser compartilháveis. A interface Flyweight não força ou garante tal compartilhamento. É comum que objetos FlyweightConcretoNaoCompartilhavel tenham objetos FlyweightConcreto como filhos em algum nível da estrutura.

	- **FabricaFlyweight:** Além de criar e gerenciar objetos flyweight essa classe também garante que o Flyweights sejam compartilhadas de forma apropriada. Quando um cliente solicita um Flyweight, a classe FabricaFlyweight fornece uma instância existente que seja apropriada, caso tal instância ainda não exista, FabricaFlyweight cria uma instância que atenda a solicitação.

	- **Cliente:** Mantêm uma referência para flyweight(s) armazena o estado extrínseco do flyweight(s).

- **Diagrama de Classe (Com Contexto):**
<div align="center">
  <img src="https://raw.githubusercontent.com/Willian-Brito/rabiscando-padroes-de-projeto/refs/heads/main/prints/Flyweight.png" alt="diagrama de classe sem contexto" />
</div>

- **Diagrama de Classe (Sem Contexto):**
<div align="center">
  <img src="https://raw.githubusercontent.com/Willian-Brito/rabiscando-padroes-de-projeto/refs/heads/main/prints/Flyweight%20-%20original.png" alt="diagrama de classe sem contexto" />
</div>

### 12. Proxy

- **Definição:** ​O padrão proxy fornece um substituto ou representante de outro objeto para gerenciar o acesso a ele.

- **Contexto:** Criação de um objeto Proxy Virtual para um objeto que demora muito para responder solicitações. O papel do proxy nesse exemplo é retardar a criação de tal objeto até que ele seja estritamente necessário.

- **Aplicabilidade (Quando Utilizar):**
O padrão Proxy é aplicável sempre que for necessária uma referência a um objeto que seja mais versátil e sofisticada do que um simples ponteiro.
Essas são algumas situações comuns onde o padrão Proxy é aplicável:

	1. Quando se precisa de um representante local para um objeto em um espaço de endereço diferente um **proxy remoto** pode ser aplicado.
	
	2. Quando se deseja criar objetos custosos apenas sob demanda pode se utilizar um **proxy virtual**.

	3. Quando objetos devem ter direitos de acesso diferentes, um **proxy de proteção** pode ser utilizado para controlar o acesso ao objeto original.

	4. Uma **referência inteligente (smart reference)** é uma substituição de um ponteiro simples que executa ações adicionais quando um objeto é acessado. Os usos típicos incluem:

		- Contagem do número de referências ao objeto real para que ele possa ser liberado automaticamente da memória quando não houver mais referências a ele.

		- Carregamento persistente de um objeto na memória quando é mencionado pela primeira vez.

		- Verificação de bloqueio no Objeto Real antes de ser acessado para garantir que nenhum outro objeto possa alterá-lo de forma indevida.

- **Componentes:**

	- **Cliente:** Objeto que consome a Proxy.

	- **Objeto:** Define a interface que é implementada tanto pelo ObjetoReal quanto pelo Proxy, permitindo que o Cliente trate o Proxy como sendo o ObjetoReal.

	- **ObjetoReal:** É o objeto que executa as solicitações feitas pelo Cliente. Nele estão as implementações capazes de responder tais solicitações.

	- **Proxy:** Mantém uma referência ao ObjetoReal para poder encaminhar solicitações a ele sempre que necessário. Prove para o Cliente a mesma interface do ObjetoReal para que possa ser utilizada pelo Cliente de forma transparente. Além de controlar o acesso ao ObjetoReal também pode ser responsável por criá-lo e excluí-lo.

		Algumas outras responsabilidades variam de acordo com o tipo de proxy.

		- Os ​por **proxies remotos** são responsáveis codificar uma solicitação e seus argumentos e por enviar tal solicitação codificada para o ObjetoReal em um espaço de endereço diferente.
		- Já os **proxies virtuais** podem fazer cache de informações adicionais sobre o ObjetoReal, para seja possível adiar o acesso direto a ele.
		- Por fim, os **proxies de proteção** verificam se o Cliente possui as permissões de acesso necessárias para executar uma solicitação.

- **Diagrama de Classe (Com Contexto):**
<div align="center">
  <img src="https://raw.githubusercontent.com/Willian-Brito/rabiscando-padroes-de-projeto/refs/heads/main/prints/Proxy.png" alt="diagrama de classe sem contexto" />
</div>

- **Diagrama de Classe (Sem Contexto):**
<div align="center">
  <img src="https://raw.githubusercontent.com/Willian-Brito/rabiscando-padroes-de-projeto/refs/heads/main/prints/Proxy%20-%20original.png" alt="diagrama de classe sem contexto" />
</div>

## 🚀 Padrões Comportamentais

### Chain of Responsibility

- **Definição:** O Padrão Chain of Responsibility evita o acoplamento do remetente de uma solicitação ao seu receptor, dando a mais de um objeto a oportunidade de tratar a solicitação. Ele encadeia os objetos receptores, passando a solicitação ao longo da cadeia até que um objeto a trate.

- **Contexto:** Calculo de pontos em um plano de fidelização de cliente com base no valor do pedido feito no sistema de uma hamburgueria.

- **Aplicabilidade (Quando Utilizar):**
	- Quando mais de um objeto pode tratar uma solicitação e não se sabe qual objeto fará tal tratamento. O objeto que trata a solicitação deve ser escolhido automaticamente.

	- Ao ser necessário fazer uma solicitação para um dentre vários objetos sem especificar explicitamente para qual.

	- Quando um conjunto de objetos que pode tratar uma solicitação deve ser especificado dinamicamente.

- **Componentes:**
	- **Cliente:** Objeto que faz a solicitação.

	- **Manipulador:** Define uma interface para tratar solicitações e pode implementar o elo (link) ao seu sucessor.

	- **ManipuladorConcreto:** Classes candidatas a atender a solicitação do cliente. Pode acessar seu sucessor, portanto ele tenta atender a solicitação do cliente, caso não consiga, passa tal solicitação ao seu sucessor.

- **Diagrama de Classe (Com Contexto):**
<div align="center">
  <img src="https://raw.githubusercontent.com/Willian-Brito/rabiscando-padroes-de-projeto/refs/heads/main/prints/Chain%20of%20Responsability.png" alt="diagrama de classe sem contexto" />
</div>

- **Diagrama de Classe (Sem Contexto):**
<div align="center">
  <img src="https://raw.githubusercontent.com/Willian-Brito/rabiscando-padroes-de-projeto/refs/heads/main/prints/Chain%20of%20Responsability%20-%20original.png" alt="diagrama de classe sem contexto" />
</div>

### Command

- **Definição:** ​O padrão de projeto Command encapsula uma solicitação como um objeto, isso lhe permite parametrizar clientes com diferentes solicitações, enfileirar ou registrar (log) solicitações e suportar solicitações que podem ser desfeitas.

- **Contexto:** Dinamização e automação dos comandos que um aplicativo envia para dispositivos inteligentes, tais como lâmpadas e aparelhos de ar-condicionado em uma smart home.

- **Aplicabilidade (Quando Utilizar):**
	- Quando é preciso parametrizar objetos como ação a ser executada:

		- Tal parametrização pode ser expressada numa linguagem procedural através de uma função callback, ou seja, uma função que é registrada em algum lugar para ser chamada em um momento mais adiante.

		- Os Comandos são uma substituição orientada callbacks.

	- Quando há necessidade de especificar, enfileirar e executar solicitações em tempos diferentes:

		- Um objeto Comando, sabe quais ações executar e conhece o objeto receptor capaz de executá-las. Ele pode executar as ações a qualquer momento, deste modo, pode ter um tempo de vida independente da solicitação original.

		- É possível enfileirar Comandos para serem executados de forma	controlada.

	- Para suportar desfazer operações:

		- Para desfazer seus efeitos, um comando pode armazenar os estados em que objeto receptor se encontrava antes da a execução das ações (chamada do método execute()).

		- A interface Command pode conter uma operação undo(), que reverte os efeitos de uma chamada anterior de execute(). De acordo com a complexidade da reversão ela pode ser baseada nos estados em que o receptor se encontrava anteriormente.

		- Os comandos executados podem ser armazenados em uma lista histórica.

		- O nível ilimitado de desfazer e refazer operações é obtido percorrendo esta lista para trás e para frente, chamando operações undo() e execute() respectivamente.

	- Para tornar possível que mudanças no sistema sejam recuperadas por meio de um registro de mudanças (logging) em caso de queda:

		- Ao aumentar a interface de Command com as operações load() e store(), pode-se manter um registro (log) persistente das mudanças feitas no objeto receptor.

		- A recuperação de uma queda de sistema envolve a recarga dos comandos registrados a partir do disco e sua reexecução com a operação execute().

	- Se faz necessário estruturar um sistema em torno de operações de alto nível construídas sobre operações primitivas:

		- Tal estrutura é comum em sistemas de informação que suportam transações.

		- Uma transação encapsula um conjunto de mudanças nos dados.
		- O padrão Command fornece uma maneira de modelar transações, já que os comandos podem ser desfeitos para o caso algum deles falhar.

		- Os Commands têm uma interface comum, permitindo invocar todas as transações da mesma maneira.

		- O padrão também torna mais fácil estender o sistema com novas transações.

- **Componentes:**

	- **Cliente:** É o responsável pela criação de um ComandoConcreto e pela definição de seu receptor.

	- **Invocador:** Contém um comando e em algum momento pede ao comando para entender uma solicitação chamando o seu método execute().

	- **Command:** Declara uma interface para todos os comandos. Um comando é invocado através de seu método execute(), que pede a um receptor para executar uma ação. Essa interface também pode possuir um método undo(), que desfaz a última ação executada.

	- **ComandoConcreto:** Implementa a interface Command e define um vínculo entre uma ação e um objeto Receptor. Implementa o método execute através da invocação da(s) correspondente(s) operação(ões) no Receptor.

	- **Receptor:** O receptor sabe como executar as tarefas necessárias para atender a uma solicitação, qualquer classe pode atuar como um receptor.

- **Diagrama de Classe (Com Contexto):**
<div align="center">
  <img src="https://raw.githubusercontent.com/Willian-Brito/rabiscando-padroes-de-projeto/refs/heads/main/prints/Command.png" alt="diagrama de classe sem contexto" />
</div>

- **Diagrama de Classe (Sem Contexto):**
<div align="center">
  <img src="https://raw.githubusercontent.com/Willian-Brito/rabiscando-padroes-de-projeto/refs/heads/main/prints/Command%20-%20original.png" alt="diagrama de classe sem contexto" />
</div>

### Interpreter

- **Definição:** O padrão Interpreter busca definir uma representação para a gramática de uma determinada linguagem, juntamente com um interpretador que usa tal representação para interpretar sentenças dessa linguagem.

- **Contexto:** Criação de um interpretador de expressões matemáticas de adição, subtração, multiplicação e divisão entre dígitos ou variáveis. Tais expressões seguem a NPS (reverse polish notation).

- **Aplicabilidade (Quando Utilizar):** O padrão Interpreter pode ser utilizado quando existe uma linguagem para interpretar e é possível representar instruções da linguagem como árvores sintáticas abstratas. O Interpreter funciona melhor quando:

	- A gramática é simples. Para gramáticas complexas, a hierarquia de classes da gramática se torna grande e incontrolável.

	- Eficiência não é uma preocupação crítica. Os Interpreters mais eficientes geralmente não são implementados pela interpretação direta de árvores de análise sintática abstrata, mas pela tradução primeiro para outra forma.

- **Componentes:**

	- **ExpressaoAbstrata:** Declara um método abstrato interpretar() comum a todos os nós na árvore sintática abstrata.

	- **ExpressaoNaoTerminal:**
		- É necessária uma classe desse tipo para cada regra R ::= R1 R2 .. .Rn da gramática.

		- Mantém variáveis de instância do tipo ExpressaoAbstrata para cada um dos símbolos R1 a Rn.

		- Implementa um método interpretar() associado aos símbolos não terminais da gramática. O método interpretar() chama a si próprio recursivamente nas variáveis que representam R1 a Rn.

	- **ExpressaoTerminal:**
		- Implementa um método interpretar() associado aos símbolos terminais da gramática, ele define o caso base da recursão iniciada por uma ExpressaoNaoTerminal.

		- É necessária uma instância para cada símbolo terminal em uma sentença.

	- **Contexto:** Contém informação que é global para o interpretador.

	- **Cliente:** Constrói ou recebe uma árvore sintática abstrata que representa uma determinada sentença da linguagem definida pela gramática. A Árvore sintática abstrata é montada a partir de instâncias das classes ExpressaoNaoTerminal e ExpressaoTerminal.

- **Diagrama de Classe (Com Contexto):**
<div align="center">
  <img src="https://raw.githubusercontent.com/Willian-Brito/rabiscando-padroes-de-projeto/refs/heads/main/prints/Interpreter.png" alt="diagrama de classe sem contexto" />
</div>

- **Diagrama de Classe (Sem Contexto):**
<div align="center">
  <img src="https://raw.githubusercontent.com/Willian-Brito/rabiscando-padroes-de-projeto/refs/heads/main/prints/Interpreter%20-%20original.png" alt="diagrama de classe sem contexto" />
</div>

### Iterator

- **Definição:** ​O padrão de projeto Iterator  fornece uma maneira de acessar, sequencialmente, os elementos de um objeto agregado sem expor a sua representação subjacente.

- **Contexto:** Criação de iteradores que atuam sobre uma lista e sobre uma matriz, removendo tal responsabilidade de quem as utiliza.

- **Aplicabilidade (Quando Utilizar):**
	- Quando é necessário acessar o conteúdo de um objeto agregado sem expor sua representação interna.

	- Quando é preciso suportar vários tipos de iteração em objetos agregados.

	- Quando é necessário fornecer uma interface uniforme para iterar sobre diferentes estruturas agregadas (ou seja, para suportar iteração polimórfica).

- **Componentes:**
	- **Cliente:** Precisa iterar sobre os objetos agregados.

	- **Agregado:** Define uma interface para criação de um objeto Iterator. O cliente espera essa interface ao invés de agregados concretos.

	- **AgregadoConcreto:** Possui uma coleção de objetos e implementa o método que retorna um objeto do tipo Iterator referente a sua coleção.

	- **Iterator:** Fornece a interface que todos os iteradores concretos devem implementar, bem como um conjunto de métodos para acessar os elementos de um agregado.

	- **IteratorConcreto:** Implementa a interface a interface de Iterator e mantém o controle da posição corrente no percurso do agregado.

- **Diagrama de Classe (Com Contexto):**
<div align="center">
  <img src="https://raw.githubusercontent.com/Willian-Brito/rabiscando-padroes-de-projeto/refs/heads/main/prints/Iterator.png" alt="diagrama de classe sem contexto" />
</div>

- **Diagrama de Classe (Sem Contexto):**
<div align="center">
  <img src="https://raw.githubusercontent.com/Willian-Brito/rabiscando-padroes-de-projeto/refs/heads/main/prints/Iterator%20-%20original.png" alt="diagrama de classe sem contexto" />
</div>

### Mediator
- **Definição:** O padrão Mediator é um padrão de projeto que serve para **encapsular a maneira que um conjunto de objetos interage**, ou seja, a comunicação entre os objetos é estabelecida através de um objeto mediador (Mediator). Este padrão de projeto promove o fraco acoplamento ao evitar que objetos se refiram uns aos outros de forma explícita e permite variar suas intenções independentemente.

- **Contexto:** Criação de um mediator em um chat onde existe um chatBot moderador que impede que uma pessoa envie duas mensagens consecutivas.

- **Aplicabilidade (Quando Utilizar):**
	- Quando um conjunto de objetos se comunica de maneiras bem definidas, porém complexas. As interdependências resultantes são desestruturadas e difíceis de entender.

	- Quando reutilizar um objeto é difícil por estar fazendo referência e se comunicando com muitos outros objetos.

	- Quando um comportamento distribuído entre várias classes deve ser personalizável sem que seja necessário criar muitas subclasses.

- **Componentes:**
	- **Mediator:** Define uma interface para se comunicar com objetos do tipo Colega.

	- **MediadorConcreto:**
		- Implementa o comportamento cooperativo coordenando os objetos do tipo Colega.

		- Conhece e mantém seus colegas.

	- **Classes Colega:**
		- Cada classe do tipo Colega conhece o objeto Mediador que a coordena.

		- Sempre que um objeto do tipo Colega precisar se comunicar com outro objeto do tipo Colega, ele fará isso por meio de seu mediador (Mediator).

- **Diagrama de Classe (Com Contexto):**
<div align="center">
  <img src="https://raw.githubusercontent.com/Willian-Brito/rabiscando-padroes-de-projeto/refs/heads/main/prints/Mediator.png" alt="diagrama de classe sem contexto" />
</div>

- **Diagrama de Classe (Sem Contexto):**
<div align="center">
  <img src="https://raw.githubusercontent.com/Willian-Brito/rabiscando-padroes-de-projeto/refs/heads/main/prints/Mediator%20-%20original.png" alt="diagrama de classe sem contexto" />
</div>

### Visitor
- **Definição:** O padrão de projeto Visitor representa uma operação a ser executada nos membros de uma estrutura de objetos. Ele permite definir uma nova operação sem mudar as classes dos membros sobre quais opera.

- **Contexto:** Cálculo de quanto lucro cada produto, departamento e supermercado é capaz de gerar em uma rede de supermercados.

- **Aplicabilidade (Quando Utilizar):**
	- Quando uma estrutura de objetos contém muitas classes com interfaces diferentes e é necessário executar operações nas instâncias dessas classes, que por sua vez dependem de suas classes concretas.

	- Quando muitas operações distintas e não relacionadas precisam ser executadas em objetos que compõem uma estrutura de objetos e não é desejável criar responsabilidades adicionais a tais objetos por conta de tais operações. O Visitor permite manter juntas as operações relacionadas, definindo-as em uma única classe. Quando a estrutura do objeto for compartilhada por muitas aplicações, use o Visitor para por operações apenas nas aplicações que precisam delas.

	- Quando as classes que definem a estrutura do objeto raramente mudam, mas geralmente é preciso definir novas operações sobre tal estrutura. Alterar as classes da estrutura do objeto requer redefinir a interface para todos os Visitors, o que é muito trabalhoso e pode criar oportunidades para surgimentos de bugs. Se as classes de estrutura dos objetos mudam com frequência, provavelmente é melhor definir as operações nessas classes.

- **Componentes:**
	- **Visitor:** Declara um método Visit() para cada classe de VisitanteConcreto na estrutura do objeto. O nome e assinatura do método indicam qual é a classe que envia a solicitação de visita ao Visitante. Isso permite que o Visitante saiba qual é o ElementoConcreto que está sendo visitado. Em seguida, o Visitante pode acessar o elemento diretamente através de sua interface específica.

	- **VisitanteConcreto:** Um VisitanteConcreto implementa versões diferentes do mesmo comportamento, feitos sob medida para diferentes classes de ElementosConcretos.

	- **Elemento:** Define uma operação aceitar() que aceita um Visitor como parâmetro.

	- **ElementoConcreto:** Implementa uma operação aceitar() que aceita um Visitor como parâmetro. O propósito de tal método é redirecionar a chamada para o método apropriado do Visitor recebido como parâmetro que corresponde com a atual classe ElementoConcreto.

	- **EstruturaDeObjetos:**
		- É opcional.
		- Pode enumerar seus elementos.
		- Pode fornecer uma interface de alto nível para permitir que o visitante visite seus elementos.
		- Pode ser uma composição (design pattern Composite) ou uma coleção tal como uma lista, pilha ou matriz.


- **Diagrama de Classe (Com Contexto):**
<div align="center">
  <img src="https://raw.githubusercontent.com/Willian-Brito/rabiscando-padroes-de-projeto/refs/heads/main/prints/Visitor.png" alt="diagrama de classe sem contexto" />
</div>

- **Diagrama de Classe (Sem Contexto):**
<div align="center">
  <img src="https://raw.githubusercontent.com/Willian-Brito/rabiscando-padroes-de-projeto/refs/heads/main/prints/VIsitor%20-%20original.png" alt="diagrama de classe sem contexto" />
</div>

### Memento
- **Definição:** O padrão Memento permite capturar e externalizar um estado interno de um objeto sem violar o encapsulamento, deste modo, o objeto pode ser restaurado no futuro para este estado capturado.

- **Contexto:** Criação de um histórico de mudanças feitas em um textbox que possui diversos atributos, tais como font-family, font-size posição no eixo x e y entre outros. Graças ao Memento o textbox poderá ser restaurado a um estado anterior.

- **Aplicabilidade (Quando Utilizar):**
	- Quando uma captura instantânea (screenshot), total ou parcial, do estado de um objeto deve ser salva para que no futuro tal objeto possa ser restaurado para este estado salvo.

	- Quando se deseja evitar uma interface direta para obtenção do estado atual do objeto, de modo que ela exponha os detalhes de sua implementação e quebre o encapsulamento.

- **Componentes:**
	- **Memento:**
		- O Memento armazena o estado interno do objeto Originador. Ele pode armazenar muito ou pouco do estado interno do Originador, isso varia conforme as necessidades e critérios do Originador.

		- Protege seu estado contra acessos feitos por objetos que não sejam o objeto Originador. O Memento têm efetivamente duas interfaces. O Cuidador vê uma interface mínima do Memento. Ele só pode passar o Memento para outros objetos. O Originador, por outro lado, vê uma interface ampla, que permite acessar todos os dados necessários para restaurar seu estado anterior. Idealmente, somente o Originador que produziu o Memento teria permissão para acessar o estado interno dele.

		- É uma prática comum fazer o Memento imutável passando todos os dados por meio do construtor.

	- **Originador:** Cria um Memento que contém um screenshot de seu estado interno atual. Utiliza o Memento para restaurar seu estado interno.

	- **Cuidador:** É responsável pela custódia do Memento, ele nunca consulta ou manipula o conteúdo interno de um Memento. O Cuidador pode também	manter registros do histórico do Originador armazenando os Mementos em um pilha e os recuperando de maneira apropriada para restaurar o Originador.

- **Diagrama de Classe (Com Contexto):**
<div align="center">
  <img src="https://raw.githubusercontent.com/Willian-Brito/rabiscando-padroes-de-projeto/refs/heads/main/prints/Memento.png" alt="diagrama de classe sem contexto" />
</div>

- **Diagrama de Classe (Sem Contexto):**
<div align="center">
  <img src="https://raw.githubusercontent.com/Willian-Brito/rabiscando-padroes-de-projeto/refs/heads/main/prints/Memento%20-%20original.png" alt="diagrama de classe sem contexto" />
</div>

### Observer
- **Definição:** O Observer é um padrão de projeto de software que define uma dependência um-para-muitos entre objetos, de modo que quando um objeto muda seu estado, todos seus dependentes são notificados e atualizados automaticamente.

- **Contexto:** Implementação de uma Newsletter onde clientes, funcionários, parceiros e fornecedores podem se inscrever para receber emails de notícias sobre a determinada empresa.

- **Aplicabilidade (Quando Utilizar):**
	- Quando uma abstração tem dois aspectos, um depende do outro, e é necessário que eles possam variar e serem reutilizados independentemente.

	- Quando uma alteração em um objeto requer a alteração de outros, e não se conhece quantos objetos precisam ser alterados.

	- Quando um objeto deve ser capaz de notificar outros objetos sem os conhecer, ou seja, tais objetos não podem ser fortemente acoplados.

- **Componentes:**
	- **Subject:** Os objetos utilizam esta interface para se registrarem como observadores e para serem removidos.

	- **Observer:** Define uma interface de atualização para objetos que devem ser notificados sobre alterações em um Subject.

	- **AssuntoConcreto:** Sempre implementa a interface Subject além dos métodos para registrar e remover observers, o AssuntoConcreto implementa o método notifyObservers() que é utilizados para atualizar todos os observadores atuais sempre o que o estado do AssuntoConcreto é alterado. Também pode ter métodos para definir e obter seu estado.

	- **ObservadoresConcretos:** Podem ser qualquer classe que implemente a interface Observer. Cada observador se registra a um AssuntoConcreto para receber atualizações. Mantém uma referência a um objeto AssuntoConcreto (que é observado por ele). Tal referência serve para saber de onde vem as notificações e para poder se registrar e se remover.

- **Diagrama de Classe (Com Contexto):**
<div align="center">
  <img src="https://raw.githubusercontent.com/Willian-Brito/rabiscando-padroes-de-projeto/refs/heads/main/prints/Observer.png" alt="diagrama de classe sem contexto" />
</div>

- **Diagrama de Classe (Sem Contexto):**
<div align="center">
  <img src="https://raw.githubusercontent.com/Willian-Brito/rabiscando-padroes-de-projeto/refs/heads/main/prints/Observer%20-%20original.png" alt="diagrama de classe sem contexto" />
</div>

### State
- **Definição:** O padrão de projeto State permite que um objeto altere o seu comportamento quando o seu estado interno muda. O objeto parecerá ter mudado de classe.

- **Contexto:** Gerenciamento de ações que podem ser realizadas em um pedido de um e-commerce conforme o estado em que o pedido se encontra.

- **Aplicabilidade (Quando Utilizar):**
	- Quando o comportamento de um objeto depende do seu estado interno, e com base nele muda seu comportamento em tempo de execução.

	- Quando operações possuírem instruções condicionais grandes que dependam do estado interno do objeto. Frequentemente várias destas operações terão a mesmas estruturas condicionais.

- **Componentes:**
	- **Contexto:** É a classe que pode ter vários estados internos diferentes. Ela mantém uma instância de uma subclasse EstadoConcreto que define	seu estado interno atual. Sempre que uma solicitação é feita ao contexto, ela é delegada ao estado atual para ser processada.

	- **State:** Define uma interface (ou classe abstrata) comum para todos os estados concretos.

	- **EstadoConcreto:** Lidam com as solicitações provenientes do contexto. Cada EstadoConcreto fornece a sua própria implementação de uma solicitação. Deste modo, quando o contexto muda de estado interno o seu comportamento também muda.

- **Diagrama de Classe (Com Contexto):**
<div align="center">
  <img src="https://raw.githubusercontent.com/Willian-Brito/rabiscando-padroes-de-projeto/refs/heads/main/prints/State.png" alt="diagrama de classe sem contexto" />
</div>

- **Diagrama de Classe (Sem Contexto):**
<div align="center">
  <img src="https://raw.githubusercontent.com/Willian-Brito/rabiscando-padroes-de-projeto/refs/heads/main/prints/State%20-%20orignal.png" alt="diagrama de classe sem contexto" />
</div>

### Strategy:
- **Definição:** O padrão de projeto Strategy define uma família de algoritmos que podem ser intercambiados, ou seja, utilizar um algoritmo no lugar de outro, conforme a necessidade de quem os utiliza.
		
- **Contexto:** Cálculo de diferentes tipos de frete disponíveis para pedidos feitos em setores distintos de um e-commerce.

- **Aplicabilidade (Quando Utilizar):**
	- O padrão é aplicado quando muitas classes fazem a mesma coisa de forma diferente.

	- Quando se necessita de variantes de um algoritmo.
	- Quando é necessário evitar a exposição de dados ou algoritmos sensíveis os quais clientes não podem ter conhecimento.

	- Remoção de operadores condicionais que determinam o comportamento do algoritmo com base em objetos diferentes.

- **Componentes:**
	- **Contexto:** Classe que é composta por um objeto que implementa a interface Strategy. Ele é responsável por orquestrar as classes EstrategiasConcretas. Sempre que uma solicitação é feita à classe contexto ela é delegada o objeto Strategy que a compõe.

	- **Strategy:** Contrato que as EstragiaConcretas devem respeitar. Tal contrato será exigido pela classe Contexto.

	- **EstrategiaConcreta:** Lidam com as solicitações provenientes do contexto. Cada EstrategiaConcreta fornece a sua própria implementação de uma solicitação. Deste modo, quando o contexto muda de estratégia o seu comportamento também muda.

- **Diagrama de Classe (Com Contexto):**
<div align="center">
  <img src="https://raw.githubusercontent.com/Willian-Brito/rabiscando-padroes-de-projeto/refs/heads/main/prints/Strategy.png" alt="diagrama de classe sem contexto" />
</div>

- **Diagrama de Classe (Sem Contexto):**
<div align="center">
  <img src="https://raw.githubusercontent.com/Willian-Brito/rabiscando-padroes-de-projeto/refs/heads/main/prints/Strategy%20-%20original.png" alt="diagrama de classe sem contexto" />
</div>

### Template Method
- **Definição:** ​​O padrão Template Method define o esqueleto de um algoritmo dentro de um método, transferindo alguns de seus passos para subclasses.
		
- **Contexto:** ​Implementação de um módulo de pagamentos do sistema de uma loja de confecções. Cada tipo de pagamento aplica diferentes taxas e descontos ao seu valor.

- **Aplicabilidade (Quando Utilizar):**
	- Para implementar partes invariantes de um algoritmo apenas uma vez, deixando para as subclasses apenas a implementação daquilo que pode variar.

	- Controlar extensões de subclasses, sabendo o que as subclasses devem implementar e até onde devem implementar.

	- Evitar duplicação de código entre classes comuns.
	
- **Componentes:**
	- **ClasseAbstrata:** Superclasse abstrata que contém os métodos concretos e abstratos que serão comuns a todas suas subclasses. Implementa o templateMethod() que define o esqueleto de um algoritmo.

	- **ClasseConcreta:** Classes que herdam os métodos concretos de conforme suas ClasseAbstrata e implementam os métodos abstratos specificidades.

- **Diagrama de Classe (Com Contexto):**
<div align="center">
  <img src="https://raw.githubusercontent.com/Willian-Brito/rabiscando-padroes-de-projeto/refs/heads/main/prints/Template%20Method.png" alt="diagrama de classe sem contexto" />
</div>

- **Diagrama de Classe (Sem Contexto):**
<div align="center">
  <img src="https://raw.githubusercontent.com/Willian-Brito/rabiscando-padroes-de-projeto/refs/heads/main/prints/Template%20Method%20-%20original.png" alt="diagrama de classe sem contexto" />
</div>

## 📝 Licença

Este projeto esta sobe a licença [MIT](./LICENSE).

Feito com ❤️ por Willian Brito 👋🏽 [Entre em contato!](https://www.linkedin.com/in/willian-ferreira-brito/)