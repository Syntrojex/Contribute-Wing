# 🚀 Contribute Wing
 
> A beginner-friendly open-source repository designed to master Git & GitHub workflows through hands-on practice (Fork, Clone, Branch, Commit, Push, and PRs).
 
A beginner-friendly sandbox where developers take their **first real steps into open source** — no complex codebase, no pressure, just the actual Git & GitHub workflow used everywhere in the real world.
 
Created by **Muhammad Mustafa** ([@Syntrojex](https://github.com/Syntrojex))
 
---

## 📌 What Is This Repository?

**Contribute Wing** isn't a "real" software project with a codebase to maintain — it's a **training ground**. A safe, structured space where developers add two small files to the `contributions/` folder:

- 📝 A short **profile** introducing themselves
- 💻 A **code snippet** in any programming language they like — C++, Python, Dart, JavaScript, Java, whatever they know

That's genuinely it. Simple enough for a complete first-timer, yet it walks you through the **exact same steps** used in real open-source contributions: fork → clone → branch → commit → push → pull request.

No complicated setup. No fear of breaking something important. Just the real workflow, practiced safely.

---

## 🧭 How It Works

```
Fork  →  Clone  →  Branch  →  Add Your Files  →  Commit  →  Push  →  Pull Request  →  Merged 🎉
```

1. **Fork** this repository to your own GitHub account
2. **Clone** your fork to your machine
3. **Create a branch** named after yourself
4. **Add your files** inside `contributions/` — a profile `.md` + a code snippet in your language of choice
5. **Update the Contributors table** with your entry
6. **Commit, push,** and open a **Pull Request**
7. Get merged and see your name live in the repository 🎉
8. The goal is to help beginners become comfortable with the **real contribution workflow before contributing to larger or more complex open-source projects.**

> 🌱 Start small. Practice the workflow. Then contribute to bigger projects with confidence.

---

## 📂 Repository Structure

```text
Contribute-Wing/
├── README.md
├── Contributors.md
├── LICENSE
├── .gitignore
└── contributions/
    ├── 0-About the Author.md
    ├── 0-Syntrojex.cs
    ├── 1-contributor-name.md
    ├── 1-contributor-name.py
    └── ...
```

---

## 🤝 How to Contribute

### 1. Fork the Repository

Click **Fork** at the top-right of this repository's GitHub page.

### 2. Clone Your Fork

```bash
git clone https://github.com/Syntrojex/Contribute-Wing.git
cd Contribute-Wing
```

### 3. Create a Branch

```bash
git checkout -b YOUR-NAME
```

### 4. Add Your Two Files

Inside `contributions/`, create:

1. **Profile file:** `contributions/your-name.md`
2. **Code file:** `contributions/your-name.ext` — use your language's real extension (not `.md`)

```
.cpp → C++      .py → Python     .js → JavaScript   .ts → TypeScript
.java → Java    .cs → C#         .dart → Dart        .html → HTML
.go → Go        .rb → Ruby       .kt → Kotlin        .swift → Swift
.php → PHP      .rs → Rust       .c → C
```

Use lowercase + hyphens, for example: `your-name.md`, `your-name.cpp`

**📄 Profile Template — copy into `your-name.md`:**

```markdown
# 👨‍💻 Contributor Profile

![Contributor](https://img.shields.io/badge/STATUS-ACTIVE-brightgreen?style=for-the-badge)

## 📌 Personal Details

| Attribute | Details |
| :--- | :--- |
| **Full Name** | [Your Name] |
| **University** | [Your University] |
| **Semester** | [e.g. 3rd] |
| **Degree** | [e.g. BS Computer Science] |
| **GitHub** | [@your-username](https://github.com/your-username) |

## 🎯 Why I'm Contributing

* Practicing Git & GitHub workflow
* Learning to submit real pull requests
* Becoming part of the open-source community
```

**💻 Code File Example — copy into `your-name.ext`:**

Just raw code — no Markdown wrapping needed. Pick your language below to see a sample:

<details>
<summary><b>C++</b> — <code>your-name.cpp</code></summary>

```cpp
#include <iostream>
using namespace std;

int main() {
    cout << "Hello, World! Thanks for checking out my first PR 🎉" << endl;
    return 0;
}
```

</details>

<details>
<summary><b>Python</b> — <code>your-name.py</code></summary>

```python
def main():
    print("Hello, World! Thanks for checking out my first PR 🎉")

main()
```

</details>

<details>
<summary><b>JavaScript</b> — <code>your-name.js</code></summary>

```javascript
function main() {
    console.log("Hello, World! Thanks for checking out my first PR 🎉");
}

main();
```

</details>

<details>
<summary><b>Java</b> — <code>your-name.java</code></summary>

```java
public class Main {
    public static void main(String[] args) {
        System.out.println("Hello, World! Thanks for checking out my first PR 🎉");
    }
}
```

</details>

<details>
<summary><b>C#</b> — <code>your-name.cs</code></summary>

```csharp
using System;

class Program {
    static void Main() {
        Console.WriteLine("Hello, World! Thanks for checking out my first PR 🎉");
    }
}
```

</details>

<details>
<summary><b>Dart</b> — <code>your-name.dart</code></summary>

```dart
void main() {
  print("Hello, World! Thanks for checking out my first PR 🎉");
}
```

</details>

<details>
<summary><b>Go</b> — <code>your-name.go</code></summary>

```go
package main

import "fmt"

func main() {
    fmt.Println("Hello, World! Thanks for checking out my first PR 🎉")
}
```

</details>

<details>
<summary><b>TypeScript</b> — <code>your-name.ts</code></summary>

```typescript
function main(): void {
    console.log("Hello, World! Thanks for checking out my first PR 🎉");
}

main();
```

</details>

<details>
<summary><b>Kotlin</b> — <code>your-name.kt</code></summary>

```kotlin
fun main() {
    println("Hello, World! Thanks for checking out my first PR 🎉")
}
```

</details>

<details>
<summary><b>Swift</b> — <code>your-name.swift</code></summary>

```swift
print("Hello, World! Thanks for checking out my first PR 🎉")
```

</details>

<details>
<summary><b>PHP</b> — <code>your-name.php</code></summary>

```php
<?php
echo "Hello, World! Thanks for checking out my first PR 🎉";
```

</details>

<details>
<summary><b>Rust</b> — <code>your-name.rs</code></summary>

```rust
fn main() {
    println!("Hello, World! Thanks for checking out my first PR 🎉");
}
```

</details>

<details>
<summary><b>Ruby</b> — <code>your-name.rb</code></summary>

```ruby
puts "Hello, World! Thanks for checking out my first PR 🎉"
```

</details>

<details>
<summary><b>C</b> — <code>your-name.c</code></summary>

```c
#include <stdio.h>

int main() {
    printf("Hello, World! Thanks for checking out my first PR 🎉\n");
    return 0;
}
```

</details>

### 5. Commit & Push

```bash
git add contributions/your-name.md contributions/your-name.ext
git commit -m "Add [Your Name] as a contributor"
git push origin YOUR-NAME
```

### 6. Open a Pull Request

Go to your fork → **Compare & pull request** → add a short description → submit.

Once merged, you're officially a contributor ✅ — the maintainer will add your name to `Contributors.md` for you.

---

## 🌟 Contributors

See everyone who's contributed in **[Contributors.md](./Contributors.md)** — once your PR is merged, the maintainer will add your name there. No need to edit that file yourself.

---

## 🙏 Special Thanks

<p align="center">
  <img src="https://img.shields.io/badge/Gratitude-💛-yellow?style=for-the-badge" alt="gratitude" />
</p>

<p align="center">
Thanks to <b>Ali Khalid</b> for the guidance and support that helped shape this repository. 🙌
</p>

<p align="center">
<a href="https://github.com/Alikhalid107">
<img src="https://img.shields.io/badge/-Ali_Khalid-181717?style=for-the-badge&logo=github&logoColor=white" alt="Ali Khalid GitHub" />
</a>
</p>

---

## 📜 License

Licensed under the [MIT License](./LICENSE) — free to fork, star, and use as a template.

---

<p align="center">
⭐ <b>If this repository helped you, consider giving it a star!</b> ⭐
</p>

<p align="center">
<b>Created by Muhammad Mustafa (<a href="https://github.com/Syntrojex">Syntrojex</a>)</b>
</p>
