package com.example.demo.controller;

import com.example.demo.model.TextEntry;
import com.example.demo.repository.TextEntryRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

@RestController
@RequestMapping("/api")
@CrossOrigin(origins = "*") // Разрешаем все источники
public class TextController {

    private final TextEntryRepository repository;

    @Autowired
    public TextController(TextEntryRepository repository) {
        this.repository = repository;
    }

    @PostMapping("/save-text")
    public ResponseEntity<?> saveText(@RequestBody TextEntry entry) {
        try {
            TextEntry savedEntry = repository.save(entry);
            return new ResponseEntity<>(savedEntry, HttpStatus.CREATED);
        } catch (Exception e) {
            return new ResponseEntity<>("Ошибка базы данных", HttpStatus.INTERNAL_SERVER_ERROR);
        }
    }
}
