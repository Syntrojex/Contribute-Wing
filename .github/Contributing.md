# 🤝 How to Contribute

Welcome! Whether this is your first pull request ever or your fiftieth, this guide walks you through everything you need to make a real, mergeable contribution to **Contribute Wing** — no prior open-source experience required. 🚀

---

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

Inside `Contributions/`, create:

1. **Profile file:** `Contributions/_Contributors Profiles/your-name.md`
2. **Code file:** inside the matching language folder — `Contributions/[Language]/your-name.ext` (create the language folder if it doesn't exist yet)

```
.cpp → C++      .py → Python     .js → JavaScript   .ts → TypeScript
.java → Java    .cs → C#         .dart → Dart        .html → HTML
.go → Go        .rb → Ruby       .kt → Kotlin        .swift → Swift
.php → PHP      .rs → Rust       .c → C          .asm → Assembly
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

<details>
<summary><b>Assembly</b> — <code>your-name.asm</code></summary>

```asm
.model small
.stack 100h

.data
    msg db 'Hello, World! Thanks for checking out my first PR$'

.code
main proc
    mov ax, @data
    mov ds, ax

    mov ah, 09h
    lea dx, msg
    int 21h

    mov ah, 4Ch
    int 21h
main endp
end main
```

</details>

### 5. Commit & Push

```bash
git add "Contributions/_Contributors Profiles/your-name.md" Contributions/[Language]/your-name.ext
git commit -m "Add [Your Name] as a contributor"
git push origin YOUR-NAME
```

### 6. Open a Pull Request

Go to your fork → **Compare & pull request** → add a short description → submit.

Once merged, you're officially a contributor ✅ — the maintainer will add your name to `Contributors.md` for you.

---

## 📏 Contribution Rules

- ✅ Two files per contributor (profile `.md` + code in its real extension)
- ✅ Filenames match your name (lowercase-with-hyphens)
- ❌ Don't edit or delete other contributors' files
- ❌ Don't modify `README.md` in your PR (unless fixing a typo)

---

Read our [Code of Conduct](./CODE_OF_CONDUCT.md) before contributing.

<p align="center">
Happy Contributing! — <b>Syntrojex</b>
</p>
