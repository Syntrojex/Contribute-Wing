# 🚀 Contribute Wing

> A beginner-friendly open-source repository designed to master Git & GitHub workflows through hands-on practice (Fork, Clone, Branch, Commit, Push, and PRs).

A beginner-friendly sandbox where developers take their **first real steps into open source** — no complex codebase, no pressure, just the actual Git & GitHub workflow used everywhere in the real world.

Created by **Muhammad Mustafa** ([@Syntrojex](https://github.com/Syntrojex))

---

## 📌 What Is This Repository?
 
**Contribute Wing** isn't a "real" software project with a codebase to maintain — it's a **training ground**. A safe, structured space where developers add two small files to the `contributors/` folder:
 
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
4. **Add your files** inside `contributors/` — a profile `.md` + a code snippet in your language of choice
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
├── CONTRIBUTORS.md
├── LICENSE
├── .gitignore
└── contributors/
    ├── 0-About the Author.md
    ├── 0-syntrojex.cs
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
git checkout -b add-YOUR-NAME
```
 
### 4. Add Your Two Files
 
Inside `contributors/`, create:
 
1. **Profile file:** `contributors/your-name.md`
2. **Code file:** `contributors/your-name.ext` — use your language's real extension (not `.md`)
```
.cpp → C++      .py → Python     .js → JavaScript   .ts → TypeScript
.java → Java    .cs → C#         .dart → Dart        .html → HTML
.go → Go        .rb → Ruby       .kt → Kotlin        .swift → Swift
.php → PHP      .rs → Rust       .c → C
```
 
Use lowercase + hyphens, For Example: `your-name.md`, `your-name.cpp`
 
<details>
<summary><b>📄 Profile Template (click to expand)</b></summary>
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
 
</details>
<details>
<summary><b>💻 Code File Example (click to expand)</b></summary>
Just raw code — no Markdown wrapping needed:
 
```cpp
#include <iostream>
using namespace std;
 
int main() {
    cout << "Hello, World! Thanks for checking out my first PR 🎉" << endl;
    return 0;
}
```
 
</details>
### 5. Add Your Name to CONTRIBUTORS.md
 
Open `CONTRIBUTORS.md` and add a row with your name.
 
### 6. Commit & Push
 
```bash
git add contributors/your-name.md contributors/your-name.ext CONTRIBUTORS.md
git commit -m "Add [Your Name] as a contributor"
git push origin add-YOUR-NAME
```
 
### 7. Open a Pull Request
 
Go to your fork → **Compare & pull request** → add a short description → submit.
 
Once merged, you're officially a contributor ✅

---

## 🌟 Contributors
 
See everyone who's contributed in **[CONTRIBUTORS.md](./CONTRIBUTORS.md)** — Your name will also be added there.
 
---
