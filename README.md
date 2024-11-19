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

- **Solução:** Simulação de um emissor de boletos com diferentes cálculos de juros, desconto e multa para dois bancos diferentes.

- **Aplicabilidade (Quando Utilizar):**

- **Componentes:**

### 2. Builder
- **Definição:** O padrão Builder separa a construção de um objeto complexo de sua representação de modo que o mesmo processo de construção de um objeto possa criar diferentes representações.

- **Solução:** Criação de um Builder para uma classe que gera PDFs, onde tal classe possui muitos parâmetros em sua criação.

- **Aplicabilidade (Quando Utilizar):**

- **Componentes:**

### 3. Factory Method
- **Definição:** O Padrão Factory Method define uma interface para criar um objeto, mas permite que a subclasses possam decidir qual classe instanciar, possibilitando que uma classe seja capaz de prorrogar a instanciação de uma classe para subclasses.

- **Solução:** Simulação de um emissor de boletos com diferentes cálculos de juros, desconto e multa para dois bancos diferentes. Tais boletos também possuem 3 diferente prazos de vencimentos pré-estipulados.

- **Aplicabilidade (Quando Utilizar):**

- **Componentes:**

### 4. Prototype
- **Definição:** O padrão Prototype especifica tipos de objetos a serem criados usando como base uma instância de outro objeto que serve como protótipo. Este padrão permite a clonagem de objetos existentes sem provocar dependência de suas classes.

- **Solução:** Criação de protótipos de objetos semelhantes e de difícil criação que são muito requisitados no sistema de uma biblioteca virtual.

- **Aplicabilidade (Quando Utilizar):**

- **Componentes:**

### 5. Singleton
- **Definição:** O padrão Singleton garante que uma classe tenha apenas uma instância e fornece um ponto global de acesso a ela.

- **Solução:** Criação de um único objeto de conexão a um banco de dados, evitando abertura de conexões desnecessárias.

- **Aplicabilidade (Quando Utilizar):**

- **Componentes:**

## ⚙️ Padrões Estruturais

### 6. Adapter
- **Definição:** O padrão Adapter converte a interface de uma classe para outra interface que o cliente esperar encontrar. O Adaptador permite que classes com interfaces incompatíveis trabalhem juntas.

- **Solução:** Adaptação de interfaces de Gateway de pagamentos que antes eram incompatíveis com a interface que nosso sistema esperava.

- **Aplicabilidade (Quando Utilizar):**
	- Quando existe a necessidade de utilizar uma classe existente e sua interface é diferente da esperada.

	- Quando se deseja criar uma classe reutilizável que coopera com classes não relacionadas a ela ou que não foram previstas, ou seja, classes que não necessariamente têm interfaces compatíveis.
	- (Somente para adaptadores de objeto) Quando é necessário usar várias subclasses existentes, mas é impraticável adaptar sua interface sub-classificando cada uma delas. Um adaptador de objeto pode adaptar a interface de sua superclasse.

- **Componentes:**

### 7. Bridge
- **Definição:** O Padrão Bridge desacopla uma abstração de sua implementação, ou seja, permite dividir uma classe grande ou um conjunto de classes diretamente ligadas em duas hierarquias separadas, deste modo as duas hierarquias podem variar de forma independente.

- **Solução:** Remoção de classes desnecessárias para o envio de mensagens que partem de  emissores​ de tipos distintos. Tais mensagens podem ser enviadas por canais diferentes (e-mail e SMS).

- **Aplicabilidade (Quando Utilizar):**

- **Componentes:**

### 8. Composite
- **Definição:** ​O padrão Composite permite a composição de objetos em estruturas de árvore para representar hierarquias parte-todo. Com esse padrão, os clientes podem tratar objetos individuais ou composições de objetos de maneira transparente e uniforme.

- **Solução:** Consulta, inclusão e remoção de arquivos em um sistema de diretórios que tem uma árvore como estrutura de dados. O diretório é organizado em pastas e sub-pastas.

- **Aplicabilidade (Quando Utilizar):**

- **Componentes:**

### 9. Decorator
- **Definição:** O Padrão Decorator anexa responsabilidades adicionais a um objeto dinamicamente. Os Decorators fornecem uma alternativa flexível ao uso de subclasses para extensão de funcionalidades.

- **Solução:** Cálculo de preço de pizzas no sistema de uma pizzaria onde existem diversos acréscimos de ingredientes para cada pizza.

- **Aplicabilidade (Quando Utilizar):**

- **Componentes:**

### 10. Facade
- **Definição:** O padrão Facade fornece uma interface unificada para um conjunto de interfaces em um subsistema. O Facade define uma interface de nível mais alto que facilita a utilização do subsistema.

- **Solução:** Simplificação da interface do sub-sistema de vendas de um e-commerce.

- **Aplicabilidade (Quando Utilizar):**

- **Componentes:**

### 11. Flyweight
- **Definição:** ​​O padrão Flyweight permite usar compartilhamento para suportar grandes quantidades de objetos de granularidade fina.

- **Solução:** Economia de armazenamento ao compartilhar informações comuns entre milhares de objetos "Árvore" em um software para criação de projetos de reflorestamento.

- **Aplicabilidade (Quando Utilizar):**

- **Componentes:**

### 12. Proxy
- **Definição:** ​O padrão proxy fornece um substituto ou representante de outro objeto para gerenciar o acesso a ele.

- **Solução:** Criação de um objeto Proxy Virtual para um objeto que demora muito para responder solicitações. O papel do proxy nesse exemplo é retardar a criação de tal objeto até que ele seja estritamente necessário.

- **Aplicabilidade (Quando Utilizar):**

- **Componentes:**

## 🚀 Padrões Comportamentais
