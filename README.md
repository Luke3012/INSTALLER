# 🖥️ Installer

**Installer** is a legacy software automation tool designed to download, install, and configure applications from a central database.  
Originally built to streamline work in a computer shop, it supports both single and batch installations with silent, unattended execution.

---

## 📋 Features
- **Single Program Installation** – Download and install individual software.
- **Batch Installation** – Execute multiple installs from predefined lists.
- **Silent Mode** – Complete installations without user interaction.
- **Self-Update** – Automatically downloads and applies new versions.
- **Self-Repair** – Restores functionality by re-downloading the database if errors occur.
- **Custom Install Sequences** – Each installation can define its own ordered steps.

---

## 🛠 How It Worked
1. **Download Database**  
   - Retrieves a ZIP file containing program definitions and installation scripts.
2. **Select Programs**  
   - Choose one or more applications to install.
3. **Run Installation**  
   - Executes the defined installation sequence automatically.
4. **Silent Mode (Optional)**  
   - Runs in the background without requiring user input.

---

## ⚠️ Note
Links to the original database no longer work, but the source code demonstrates the full implementation of:
- Download management
- Installation automation
- Update and repair routines

---
